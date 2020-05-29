using Cw7.DTOs.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cw7.DTOs
{
    public class EnrollStudentResult
    {
        public EnrollStudentResponse Response { get; set; }

        public ResultCodes ResultCode { get; set; }
    }
}