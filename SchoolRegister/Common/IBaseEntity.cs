namespace SchoolRegister.Common
{
    public interface IBaseEntity
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string MiddleName { get; set; }
    }
}