using System.Collections.Generic;
using SchoolRegister.Common;

namespace SchoolRegister.Models.BusinessModels
{
    public class Teacher : IBaseEntity
    {
        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public Contact Contact { get; set; }

        public ICollection<Student> Students { get; set; }

        public Teacher()
        {
            Students = new List<Student>();
        }

    }
}