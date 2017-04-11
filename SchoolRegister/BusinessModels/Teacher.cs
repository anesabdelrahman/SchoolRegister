using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SchoolRegister.Common;

namespace SchoolRegister.BusinessModels
{
    public class Teacher : IEntityId, IBaseEntity
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public Contact Contact { get; set; }

        public virtual ICollection<Student> Students { get; set; }

    }
}