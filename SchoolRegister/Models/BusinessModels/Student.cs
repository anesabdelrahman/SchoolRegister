using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using SchoolRegister.Common;

namespace SchoolRegister.Models.BusinessModels
{
    public class Student : IBaseEntity
    {
        public int StudentId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }
        public bool ReceivedBooks { get; set; }

        public string EnglishSchool { get; set; }
        public string MedicalInfo { get; set; }
        public Gender Gender { get; set; }

        [Required]
        public bool CanBePhotographed { get; set; }
        public ICollection<Parent> Parents { get; set; }
        public Address Address { get; set; }

        public Student()
        {
            Parents = new Collection<Parent>();
        }


    }
}