namespace SchoolRegister.BusinessModels
{
    public class ExamResults 
    {
        public virtual Subject Subject { get; set; }
        public virtual Student Student { get; set; }
        public virtual Exam Exam { get; set; }
        public decimal Marks { get; set; }
    }
}