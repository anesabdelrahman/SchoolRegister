using System;
using System.Collections.Generic;
using SchoolRegister.Common;

namespace SchoolRegister.BusinessModels
{
    public class Student : IEntityId, IBaseEntity
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool ReceivedBooks { get; set; }
        public string EnglishSchool { get; set; }
        public string MedicalInfo { get; set; }
        public Gender Gender { get; set; }
        public bool CanBePhotographed { get; set; }
        public virtual IEnumerable<Parent> Parents { get; set; }
        public Address Address { get; set; }


    }
}