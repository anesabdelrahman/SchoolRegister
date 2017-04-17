namespace SchoolRegister.Models.BusinessModels
{
    public class Address
    {
        public int AddressId { get; set; }
        public string FirstLine { get; set; }
        public string SecondLine { get; set; }
        public string ThirdLine { get; set; }
        public string PostCode { get; set; }
    }
}