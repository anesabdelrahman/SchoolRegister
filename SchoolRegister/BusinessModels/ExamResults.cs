using System.ComponentModel.DataAnnotations;

namespace SchoolRegister.BusinessModels
{
    public class ExamResults 
    {
        [Key]
        public int SubjectId  { get; set; }
        [Key]
        public int StudentId  { get; set; }
        public int ExamId  { get; set; }
        public decimal Marks { get; set; }

        public Student Student { get; set; }
        public Exam Exam { get; set; }
    }
}