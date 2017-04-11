using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SchoolRegister.Common;

namespace SchoolRegister.BusinessModels
{
    public class Exam : IEntityId
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime ExamDate { get; set; }
        public ExamType ExamType { get; set; }
    }
}