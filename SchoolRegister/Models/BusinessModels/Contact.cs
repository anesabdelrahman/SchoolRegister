using SchoolRegister.Common;

namespace SchoolRegister.Models.BusinessModels
{
    public class Contact
    {
        public int ContactId { get; set; }
        public int HomeTelephone { get; set; }
        public int WorkTelephone { get; set; }
        public int MobileNumber { get; set; }
        public string Email { get; set; }
        public RelationshipToChild Relationship { get; set; }

    }
}