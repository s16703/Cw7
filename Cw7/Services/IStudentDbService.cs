using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cw7.DTOs;
using Cw7.DTOs.Requests;
using Cw7.DTOs.Responses;


namespace Cw7.Services
{
    public interface IStudentDbService
    {
        public EnrollStudentResult EnrollStudent(EnrollStudentRequest request);
        public EnrollStudentResponse PromoteStudents(PromoteStudentRequest request);

        public Boolean IsThereStudent(string index);
        public Boolean CheckCredential(string user, string password);
    }
}
