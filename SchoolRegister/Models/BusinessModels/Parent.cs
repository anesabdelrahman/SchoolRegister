using System.ComponentModel.DataAnnotations;
using SchoolRegister.Common;

namespace SchoolRegister.Models.BusinessModels
{
    public class Parent : IBaseEntity
    {
        public int ParentId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string OriginalNationality { get; set; }
        public Contact Contact { get; set; }
        public Address Address { get; set; }

    }
}