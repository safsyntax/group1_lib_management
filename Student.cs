public class Student : Person
{
    private string Major;
    private int GraduationYear;
 
    public Student(string name, string email, string id, string major, int graduationYear) : base(name, email, id)
 
    {
        Major = major;
        GraduationYear = graduationYear;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Student Major: {Major},Graduation Year:{GraduationYear}");
    }
}
