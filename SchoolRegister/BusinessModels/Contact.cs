using System;
using SchoolRegister.Common;

namespace SchoolRegister.BusinessModels
{
    public class Contact : IEntityId
    {
        public Guid Id { get; set; }

        public int HomeTelephone { get; set; }
        public int WorkTelephone { get; set; }
        public int MobileNumber { get; set; }
        public string Email { get; set; }
        public RelationshipToChild Relationship { get; set; }

    }
}