using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using SchoolRegister.Common;

namespace SchoolRegister.Models.BusinessModels
{
    public class Student : IBaseEntity
    {
        public int StudentId { get; set; }

        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Surname")]
        public string LastName { get; set; }

        [DisplayName("Middle Name")]
        public string MiddleName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [DisplayName("Received Books")]
        public bool ReceivedBooks { get; set; }

        [DisplayName("English School")]
        public string EnglishSchool { get; set; }

        [DisplayName("Medical Information")]
        public string MedicalInfo { get; set; }
        public Gender Gender { get; set; }

        [Required]
        [DisplayName("Can Be Photograph")]
        public bool CanBePhotographed { get; set; }
        public ICollection<Parent> Parents { get; set; }
        public Address Address { get; set; }

        public Student()
        {
            Parents = new Collection<Parent>();
        }


    }
}