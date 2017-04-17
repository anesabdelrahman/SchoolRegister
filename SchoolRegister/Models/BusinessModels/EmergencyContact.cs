using SchoolRegister.Common;

namespace SchoolRegister.Models.BusinessModels
{
    public class EmergencyContact : IBaseEntity
    {
        public int EmergencyContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public  Contact Contact { get; set; }
    }
}