﻿using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Repository.IRepositories;
using Service.DTO;
using Service.Helpers;
using Service.IServices;
using Service.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class IndoorPatientService : IIndoorPatientService
    {
        private IDoctorService DoctorService { get; }
        private IDoctorRepository DoctorRepository { get; }
        private IIndoorPatientRepository IndoorPatientRepository { get; }
        private IAdminService AdminService { get; }
        private IPrescriptionRepository PrescriptionRepository { get; }

        public IndoorPatientService(IDoctorService _DoctorService, IIndoorPatientRepository _IndoorPatientRepository, IDoctorRepository _DoctorRepository, IAdminService _AdminService, IPrescriptionRepository _PrescriptionRepository)
        {
            DoctorService = _DoctorService;
            IndoorPatientRepository = _IndoorPatientRepository;
            DoctorRepository = _DoctorRepository;
            AdminService = _AdminService;
            PrescriptionRepository = _PrescriptionRepository;
        }

        public async Task ReservePatient(ReservePatientDto ReservePatientDto)
        {
            Doctor _OrderdByDoctor = await DoctorRepository.GetById(ReservePatientDto.OrderdByDoctorId);

            var NewIndoorPatientRecord = new IndoorPatientRecord
            {
                CauseOfAdmission = ReservePatientDto.CauseOfAdmission,
                OralMedicalHistory = ReservePatientDto.OralMedicalHistory,
                DepartmentId = ReservePatientDto.DepartmentId,
                EnterDate = ReservePatientDto.EnterDate,
                RoomId = ReservePatientDto.RoomId,
                PatientId = ReservePatientDto.PatientId,
                OrderdByDoctor = _OrderdByDoctor,
                BedId= ReservePatientDto.BedId
            };
            await AdminService.ReserveRoom(ReservePatientDto.RoomId);
            await AdminService.ReserveBed(ReservePatientDto.BedId);
            await IndoorPatientRepository.Add(NewIndoorPatientRecord);

        }

        public async Task<IEnumerable<InDoorPatientsInfo>> GetInDoorPatientsByDept(int DepartmentId)
        {
            return await IndoorPatientRepository.GetInDoorPatientsByDept(DepartmentId)
                .Select(P => new InDoorPatientsInfo()
                {
                    FirstName = P.Patient.FirstName,
                    LastName = P.Patient.LastName,
                    Age = P.Patient.Age,
                    Image = P.Patient.Image,
                    PhoneNumber = P.Patient.PhoneNumber,
                    Id = P.PatientId,
                    IndoorPatientId=P.Id,
                    Gender=P.Patient.Gender,
                    CauseOfAdmission=P.CauseOfAdmission,
                    OralMedicalHistory=P.OralMedicalHistory
                })
                .ToListAsync(); 

        }

       

         public Task<Prescription> GetLastPrescriptionByIndoorPatientId(int IndoorPatientRecordId)
        {
            return PrescriptionRepository.GetLastPrescriptionByIndoorPatientId(IndoorPatientRecordId);
        }

        public  async Task<IEnumerable<DateTime?>> GetDischargeDatesByPatientId(int PatientId)
        {
           return  IndoorPatientRepository.GetDischargeDatesByPatientId(PatientId);
        }

        public async Task<IEnumerable<int>> GetIndoorPatientRecords(int PatientId)
        {
            return IndoorPatientRepository.GetIndoorPatientRecords(PatientId); ;
        }
    }
}
