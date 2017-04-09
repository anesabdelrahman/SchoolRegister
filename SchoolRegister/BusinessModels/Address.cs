using System;
using SchoolRegister.Common;

namespace SchoolRegister.BusinessModels
{
    public class Address : IEntityId
    {
        public Guid Id { get; set; }
        public string FirstLine { get; set; }
        public string SecondLine { get; set; }
        public string ThirdLine { get; set; }
        public string PostCode { get; set; }
    }
}