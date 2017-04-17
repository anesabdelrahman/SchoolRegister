using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolRegister.Models.BusinessModels
{
    public class ExamResults 
    {
        [Key]
        [Column(Order = 1)]
        public int SubjectId  { get; set; }
        [Key]
        [Column(Order = 2)]
        public int StudentId  { get; set; }
        public int ExamId  { get; set; }
        public decimal Marks { get; set; }

        public Student Student { get; set; }
        public Exam Exam { get; set; }
    }
}