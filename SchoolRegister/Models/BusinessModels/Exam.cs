using System;
using SchoolRegister.Common;

namespace SchoolRegister.Models.BusinessModels
{
    public class Exam
    {
        public int ExamId { get; set; }
        public string Name { get; set; }
        public DateTime ExamDate { get; set; }
        public ExamType ExamType { get; set; }
    }
}