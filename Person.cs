Karthik:
 
 
namespace group1_lib_management

{
 
    public class Person

    {

        public string Name;

        public string Email;

        public string Id;
 
        public Person(string name, string email, string id)

        {

            Name = name;

            Email = email;

            Id = id;

        }
 
        public virtual void DisplayInfo()

        {

            Console.WriteLine($"Name: {Name}, ID: {Id}");

        }

    }
 