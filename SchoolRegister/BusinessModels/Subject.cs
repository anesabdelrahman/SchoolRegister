using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SchoolRegister.Common;

namespace SchoolRegister.BusinessModels
{
    public class Subject : IEntityId
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        //todo: is grade needed or use passMarks etc
    }
}