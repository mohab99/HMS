﻿using Domain.Models;
using Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IServices
{
    public interface INurseService : IUserService
    {
        Task<Nurse> AddNurse(NurseDto doc);
        Task<Nurse> UpdateNurse(NurseDto doc_dto);
        Task<IEnumerable<NurseDto>> GetAllNurses();
        Task<NurseDto> GetNurseById(int Nurse_id);
        Task<Nurse> DeleteNurse(int Nurse_id);
        Task<NurseDto> GetNurseByName(String Nursename);
    }
}