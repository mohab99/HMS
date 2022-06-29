﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain.Migrations
{
    public partial class updatedoctor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "clinicalDoctor",
                table: "Users",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDtm", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 6, 28, 20, 10, 1, 789, DateTimeKind.Local).AddTicks(4189), new byte[] { 132, 101, 127, 55, 44, 35, 105, 50, 35, 209, 73, 77, 107, 201, 178, 59, 139, 219, 81, 240, 166, 44, 113, 202, 146, 152, 49, 121, 243, 189, 95, 33, 190, 164, 32, 107, 180, 32, 2, 122, 161, 45, 130, 211, 207, 241, 208, 183, 125, 211, 240, 86, 117, 176, 14, 192, 22, 23, 105, 205, 126, 199, 252, 134 }, new byte[] { 0, 179, 72, 75, 92, 240, 249, 128, 57, 235, 13, 152, 225, 53, 132, 142, 70, 218, 52, 224, 203, 215, 249, 4, 130, 99, 166, 122, 134, 211, 231, 198, 144, 84, 88, 69, 190, 69, 123, 77, 236, 217, 178, 63, 194, 181, 97, 181, 181, 254, 106, 60, 59, 230, 142, 66, 19, 86, 209, 255, 123, 230, 177, 137, 137, 143, 36, 123, 130, 114, 18, 127, 221, 85, 186, 134, 4, 159, 27, 90, 42, 107, 142, 208, 16, 242, 91, 115, 182, 173, 95, 26, 210, 84, 16, 225, 44, 18, 40, 214, 25, 215, 228, 217, 214, 45, 179, 88, 128, 171, 200, 37, 206, 227, 237, 36, 163, 95, 95, 179, 58, 120, 180, 217, 52, 228, 200, 135 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDtm", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 6, 28, 20, 10, 1, 789, DateTimeKind.Local).AddTicks(4204), new byte[] { 169, 121, 248, 33, 222, 29, 39, 65, 10, 203, 106, 139, 74, 195, 210, 116, 241, 120, 191, 239, 14, 206, 211, 183, 101, 241, 19, 226, 136, 124, 8, 220, 16, 30, 162, 90, 43, 10, 48, 4, 39, 105, 85, 56, 165, 58, 162, 198, 161, 177, 71, 120, 190, 173, 117, 142, 63, 201, 206, 178, 153, 150, 197, 29 }, new byte[] { 252, 140, 186, 128, 213, 202, 188, 22, 239, 183, 236, 210, 23, 168, 59, 165, 144, 242, 133, 47, 87, 153, 142, 134, 236, 228, 23, 160, 28, 224, 208, 132, 122, 215, 202, 225, 167, 248, 89, 100, 9, 103, 125, 149, 163, 65, 119, 41, 41, 228, 51, 131, 123, 85, 62, 172, 243, 177, 63, 221, 37, 35, 172, 68, 53, 146, 69, 106, 178, 195, 239, 244, 48, 143, 241, 69, 191, 249, 236, 112, 31, 104, 78, 139, 203, 217, 88, 212, 104, 204, 2, 109, 207, 22, 96, 156, 78, 58, 5, 154, 134, 223, 234, 92, 77, 50, 206, 168, 243, 156, 232, 33, 70, 125, 167, 162, 237, 56, 255, 221, 31, 67, 108, 94, 34, 44, 149, 99 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDtm", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 6, 28, 20, 10, 1, 789, DateTimeKind.Local).AddTicks(4207), new byte[] { 110, 139, 15, 8, 241, 205, 118, 7, 146, 195, 176, 38, 34, 10, 16, 116, 228, 222, 39, 228, 108, 119, 76, 99, 248, 41, 115, 184, 164, 202, 173, 208, 155, 233, 40, 67, 164, 253, 194, 83, 144, 91, 248, 105, 88, 142, 148, 209, 2, 174, 64, 109, 113, 97, 110, 230, 96, 164, 157, 202, 95, 100, 19, 175 }, new byte[] { 112, 195, 166, 171, 186, 173, 85, 133, 42, 235, 233, 199, 80, 100, 140, 250, 110, 95, 51, 83, 248, 50, 146, 62, 241, 220, 179, 30, 145, 219, 140, 38, 167, 140, 56, 250, 151, 221, 122, 208, 245, 37, 207, 230, 198, 0, 65, 66, 70, 184, 33, 96, 117, 59, 148, 72, 130, 52, 215, 178, 235, 151, 213, 53, 156, 81, 157, 143, 74, 155, 36, 5, 251, 170, 114, 214, 6, 90, 168, 253, 203, 16, 126, 246, 38, 61, 44, 65, 19, 27, 13, 125, 22, 112, 22, 147, 27, 61, 39, 36, 8, 118, 17, 221, 69, 134, 247, 250, 143, 38, 161, 79, 243, 143, 47, 228, 60, 2, 16, 219, 59, 248, 100, 202, 243, 178, 171, 66 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDtm", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 6, 28, 20, 10, 1, 789, DateTimeKind.Local).AddTicks(4406), new byte[] { 27, 107, 154, 126, 213, 206, 26, 246, 168, 17, 212, 35, 133, 57, 203, 63, 3, 104, 217, 14, 66, 95, 67, 29, 175, 207, 220, 118, 33, 94, 77, 155, 114, 118, 211, 100, 94, 214, 190, 225, 127, 195, 37, 41, 195, 73, 52, 45, 100, 26, 232, 131, 207, 255, 181, 109, 113, 254, 141, 246, 217, 5, 149, 106 }, new byte[] { 220, 240, 153, 127, 86, 164, 59, 207, 203, 88, 83, 33, 220, 101, 149, 179, 137, 137, 209, 152, 139, 194, 127, 10, 78, 109, 14, 81, 225, 149, 91, 15, 207, 31, 120, 13, 242, 100, 253, 222, 211, 227, 115, 145, 208, 212, 85, 211, 145, 194, 9, 193, 54, 251, 150, 144, 202, 171, 110, 188, 200, 179, 156, 59, 25, 161, 32, 166, 150, 206, 162, 162, 215, 101, 246, 1, 34, 54, 241, 154, 224, 133, 102, 106, 51, 120, 129, 217, 214, 197, 247, 30, 83, 81, 73, 185, 107, 151, 209, 172, 137, 50, 16, 42, 98, 28, 159, 124, 241, 135, 159, 60, 174, 19, 51, 252, 201, 16, 203, 228, 50, 192, 143, 129, 251, 159, 67, 45 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDtm", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 6, 28, 20, 10, 1, 789, DateTimeKind.Local).AddTicks(4410), new byte[] { 150, 121, 221, 196, 132, 61, 167, 66, 252, 206, 222, 252, 3, 62, 94, 253, 119, 248, 169, 191, 56, 180, 7, 249, 133, 190, 118, 242, 186, 62, 235, 14, 178, 145, 106, 193, 1, 50, 94, 91, 39, 195, 113, 69, 121, 233, 64, 134, 5, 41, 231, 79, 81, 179, 197, 213, 101, 198, 201, 129, 218, 200, 100, 141 }, new byte[] { 189, 83, 206, 157, 100, 58, 69, 67, 99, 64, 98, 67, 186, 42, 139, 24, 123, 187, 69, 245, 142, 128, 186, 225, 219, 172, 186, 244, 97, 2, 65, 220, 85, 99, 46, 222, 111, 167, 55, 201, 95, 224, 207, 14, 204, 233, 248, 113, 238, 98, 103, 65, 22, 46, 103, 162, 145, 12, 82, 255, 105, 121, 153, 28, 120, 233, 193, 159, 252, 63, 33, 34, 112, 42, 95, 241, 5, 51, 163, 238, 135, 143, 134, 153, 28, 65, 231, 43, 160, 152, 57, 66, 31, 211, 228, 34, 67, 203, 9, 238, 21, 212, 130, 6, 206, 40, 174, 142, 103, 227, 198, 252, 61, 5, 157, 9, 127, 145, 186, 105, 37, 47, 54, 219, 152, 152, 196, 149 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDtm", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 6, 28, 20, 10, 1, 789, DateTimeKind.Local).AddTicks(4413), new byte[] { 126, 186, 99, 28, 4, 35, 31, 17, 127, 250, 251, 2, 122, 203, 175, 93, 85, 170, 138, 61, 236, 213, 90, 80, 174, 12, 89, 136, 224, 150, 251, 74, 191, 17, 125, 70, 226, 249, 247, 140, 11, 189, 252, 249, 104, 194, 162, 245, 242, 233, 90, 149, 21, 38, 240, 75, 202, 35, 147, 81, 109, 148, 108, 29 }, new byte[] { 33, 9, 167, 206, 124, 45, 76, 172, 62, 230, 197, 228, 86, 11, 128, 94, 110, 81, 2, 173, 249, 151, 4, 166, 231, 13, 244, 11, 224, 5, 212, 2, 239, 241, 170, 249, 230, 154, 97, 29, 59, 18, 2, 70, 190, 38, 162, 129, 137, 152, 6, 75, 148, 247, 37, 6, 212, 181, 225, 143, 73, 77, 79, 244, 208, 245, 10, 35, 206, 65, 49, 169, 207, 69, 18, 208, 9, 65, 1, 188, 52, 167, 51, 211, 10, 20, 222, 241, 164, 160, 147, 94, 91, 85, 151, 219, 68, 24, 141, 91, 62, 227, 96, 129, 109, 218, 18, 206, 124, 239, 32, 166, 228, 152, 152, 173, 199, 68, 132, 15, 253, 224, 226, 49, 146, 239, 204, 65 } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "clinicalDoctor",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDtm", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 6, 28, 20, 6, 50, 67, DateTimeKind.Local).AddTicks(996), new byte[] { 59, 95, 125, 24, 65, 16, 92, 166, 44, 154, 109, 218, 182, 139, 56, 230, 185, 39, 243, 45, 214, 104, 201, 71, 110, 3, 39, 33, 43, 127, 250, 153, 231, 157, 236, 34, 194, 39, 16, 197, 202, 130, 144, 67, 16, 73, 70, 116, 218, 159, 41, 11, 46, 222, 92, 110, 179, 97, 220, 183, 61, 37, 234, 166 }, new byte[] { 89, 128, 48, 162, 217, 166, 177, 11, 65, 204, 179, 53, 142, 232, 159, 180, 245, 148, 71, 152, 129, 13, 53, 222, 48, 35, 62, 51, 158, 251, 183, 17, 139, 218, 218, 242, 148, 196, 156, 193, 234, 197, 217, 43, 237, 211, 102, 32, 221, 15, 25, 141, 216, 146, 253, 216, 36, 45, 64, 235, 235, 238, 92, 130, 32, 147, 216, 239, 207, 81, 124, 62, 174, 236, 89, 66, 51, 244, 42, 70, 134, 69, 10, 213, 8, 212, 153, 67, 14, 115, 76, 34, 177, 126, 48, 156, 150, 51, 142, 119, 6, 103, 244, 102, 75, 255, 68, 228, 169, 166, 33, 184, 219, 15, 79, 250, 80, 169, 89, 129, 172, 172, 238, 149, 165, 19, 99, 124 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDtm", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 6, 28, 20, 6, 50, 67, DateTimeKind.Local).AddTicks(1010), new byte[] { 192, 60, 129, 251, 28, 49, 25, 53, 162, 140, 93, 22, 101, 63, 195, 7, 236, 102, 76, 26, 43, 132, 196, 210, 166, 142, 68, 20, 197, 16, 225, 71, 143, 134, 29, 141, 204, 86, 203, 54, 227, 84, 37, 63, 58, 190, 47, 91, 235, 229, 147, 176, 123, 167, 4, 123, 170, 34, 196, 223, 19, 91, 112, 1 }, new byte[] { 209, 196, 105, 48, 129, 35, 16, 219, 192, 42, 75, 215, 187, 37, 161, 0, 104, 101, 200, 85, 153, 104, 167, 234, 243, 89, 130, 112, 67, 172, 202, 170, 168, 220, 26, 74, 140, 138, 215, 113, 11, 141, 160, 0, 36, 27, 225, 146, 21, 94, 66, 24, 153, 209, 220, 210, 198, 179, 101, 72, 160, 193, 33, 78, 207, 7, 236, 249, 205, 23, 131, 230, 98, 43, 124, 25, 68, 171, 180, 55, 230, 63, 207, 23, 170, 255, 170, 242, 57, 69, 52, 226, 135, 205, 157, 6, 21, 240, 234, 76, 29, 108, 11, 225, 191, 216, 115, 121, 205, 7, 215, 202, 248, 141, 88, 57, 77, 124, 160, 190, 55, 78, 142, 158, 223, 160, 94, 246 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDtm", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 6, 28, 20, 6, 50, 67, DateTimeKind.Local).AddTicks(1014), new byte[] { 201, 184, 125, 86, 19, 141, 10, 97, 81, 175, 22, 181, 185, 158, 221, 7, 237, 133, 179, 159, 19, 200, 5, 53, 219, 89, 212, 97, 189, 129, 231, 104, 67, 19, 69, 99, 88, 55, 68, 172, 202, 105, 112, 153, 209, 131, 16, 128, 32, 127, 57, 47, 46, 22, 25, 113, 186, 75, 78, 253, 250, 208, 115, 164 }, new byte[] { 152, 150, 217, 195, 68, 203, 198, 18, 204, 151, 71, 238, 90, 96, 138, 221, 63, 147, 56, 155, 176, 136, 59, 255, 24, 184, 76, 215, 13, 127, 240, 130, 128, 228, 175, 26, 189, 241, 195, 217, 88, 113, 10, 240, 53, 86, 236, 28, 198, 195, 92, 153, 6, 110, 58, 231, 218, 80, 194, 208, 43, 211, 225, 203, 193, 211, 64, 113, 177, 253, 251, 24, 154, 205, 83, 63, 148, 88, 219, 236, 225, 40, 114, 78, 227, 245, 107, 218, 157, 5, 211, 87, 254, 221, 142, 145, 231, 255, 171, 198, 190, 105, 26, 98, 193, 156, 219, 204, 246, 169, 177, 57, 89, 188, 115, 20, 151, 24, 149, 106, 28, 252, 129, 67, 187, 22, 237, 95 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDtm", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 6, 28, 20, 6, 50, 67, DateTimeKind.Local).AddTicks(1143), new byte[] { 96, 65, 171, 39, 176, 98, 22, 170, 114, 82, 67, 50, 227, 58, 225, 66, 10, 221, 247, 179, 205, 225, 5, 90, 233, 15, 187, 140, 227, 236, 25, 144, 162, 36, 19, 28, 164, 244, 227, 136, 215, 100, 19, 210, 99, 82, 2, 44, 158, 84, 176, 178, 239, 157, 173, 178, 231, 129, 161, 130, 130, 51, 188, 19 }, new byte[] { 5, 172, 150, 222, 56, 248, 137, 46, 84, 100, 31, 7, 217, 120, 189, 38, 33, 108, 109, 19, 127, 146, 158, 53, 129, 254, 217, 172, 195, 128, 51, 67, 33, 11, 86, 77, 74, 106, 211, 32, 96, 161, 42, 79, 91, 92, 154, 117, 228, 153, 172, 43, 250, 131, 53, 144, 12, 26, 146, 36, 103, 33, 230, 231, 27, 234, 165, 181, 158, 68, 7, 95, 213, 0, 41, 232, 164, 233, 177, 91, 7, 115, 246, 246, 135, 152, 209, 70, 147, 215, 58, 223, 194, 217, 13, 189, 215, 102, 129, 124, 248, 97, 163, 170, 164, 197, 251, 242, 201, 71, 133, 237, 187, 177, 136, 6, 183, 231, 20, 251, 214, 195, 250, 212, 224, 239, 114, 28 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDtm", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 6, 28, 20, 6, 50, 67, DateTimeKind.Local).AddTicks(1146), new byte[] { 191, 114, 97, 198, 219, 172, 217, 231, 138, 116, 59, 178, 108, 79, 178, 86, 104, 136, 73, 246, 21, 61, 149, 50, 245, 249, 251, 78, 155, 4, 180, 184, 36, 14, 185, 253, 217, 216, 84, 194, 158, 85, 128, 123, 105, 116, 155, 12, 213, 249, 116, 92, 122, 70, 46, 84, 70, 16, 40, 47, 176, 49, 153, 124 }, new byte[] { 99, 117, 254, 16, 100, 181, 52, 38, 188, 195, 186, 184, 165, 241, 151, 4, 231, 64, 195, 172, 134, 188, 107, 88, 170, 215, 167, 139, 189, 251, 45, 239, 62, 179, 49, 187, 23, 7, 56, 199, 190, 186, 104, 2, 5, 76, 162, 33, 179, 192, 239, 17, 189, 28, 236, 108, 61, 155, 105, 207, 45, 28, 119, 161, 204, 159, 220, 189, 15, 168, 237, 219, 14, 16, 224, 194, 174, 3, 100, 27, 24, 70, 242, 242, 82, 249, 129, 199, 69, 115, 48, 85, 149, 36, 157, 253, 125, 190, 157, 200, 10, 164, 250, 25, 101, 16, 127, 82, 229, 241, 13, 95, 114, 214, 143, 236, 128, 235, 177, 244, 184, 42, 67, 64, 38, 34, 15, 38 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDtm", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 6, 28, 20, 6, 50, 67, DateTimeKind.Local).AddTicks(1149), new byte[] { 99, 63, 122, 213, 186, 49, 208, 253, 192, 236, 68, 52, 112, 253, 180, 24, 25, 223, 167, 79, 161, 33, 32, 77, 164, 250, 93, 118, 164, 110, 2, 108, 159, 58, 141, 118, 173, 70, 183, 213, 201, 90, 36, 209, 24, 59, 211, 12, 14, 207, 185, 112, 182, 65, 57, 191, 203, 135, 239, 202, 201, 63, 2, 37 }, new byte[] { 37, 216, 100, 33, 124, 219, 104, 107, 118, 235, 42, 127, 207, 208, 123, 17, 189, 95, 28, 208, 197, 128, 9, 220, 173, 106, 62, 205, 90, 105, 191, 243, 195, 38, 164, 239, 176, 206, 237, 176, 241, 58, 68, 98, 163, 106, 214, 137, 76, 6, 82, 107, 98, 13, 216, 166, 239, 45, 229, 140, 23, 169, 251, 130, 231, 35, 59, 109, 35, 226, 38, 196, 48, 226, 35, 152, 204, 206, 253, 162, 60, 218, 167, 127, 53, 138, 117, 71, 5, 154, 215, 217, 109, 136, 154, 45, 50, 155, 6, 73, 107, 223, 125, 236, 160, 22, 130, 8, 100, 26, 13, 2, 25, 144, 35, 6, 133, 104, 61, 127, 157, 146, 109, 139, 228, 124, 225, 95 } });
        }
    }
}
