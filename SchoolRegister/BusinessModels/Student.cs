using Microsoft.Owin.BuilderProperties;
using System;
using System.Collections.Generic;

namespace SchoolRegister.BusinessModels
{
    public class Student
    {
        public Guid StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool ReceivedBooks { get; set; }
        public string EnglishSchool { get; set; }
        public string MedicalInfo { get; set; }
        public Gender Gender { get; set; }
        public bool CanBePhotographed { get; set; }

        public IEnumerable<Parent> Parents { get; set; }
        public Address Address { get; set; }


    }

    public class Parent
    {
        public Guid ParentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string OriginalNationality { get; set; }
        public Contact Contact { get; set; }
        public Address Address { get; set; }

    }

    public class Contact
    {

    }

    public enum Gender
    {
        Male = 1,
        Female = 2
    }
}