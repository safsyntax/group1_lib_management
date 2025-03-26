public class Staff : Person
{
    public string Position;
    public string Department;
 
    public Staff(string name, string email, string id, string position, string department)
        : base(name, email, id)
    {
        Position = position;
        Department = department;
    }
}
