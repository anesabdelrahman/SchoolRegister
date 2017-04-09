using System;
using SchoolRegister.Common;

namespace SchoolRegister.BusinessModels
{
    public class Parent : IEntityId, IBaseEntity
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string OriginalNationality { get; set; }
        public Contact Contact { get; set; }
        public Address Address { get; set; }

    }
}