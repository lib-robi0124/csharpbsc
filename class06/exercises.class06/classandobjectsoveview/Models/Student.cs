
namespace classesandobjectoveview.Models
{
    public class Student
    {
        public Student()
        {

        }
        public string FullName { get; set; }
        public int Age { get; set; }
        public Group Group { get; set; }
        public Student(string fullname, int age, Group group)
        {
            FullName = fullname;
            Age = age;
            Group = group;
        }
        public Student(string fname, string lname, int age)
        {
            FullName = $"{fname} {lname}";
            Age = age;
        }

    }
}