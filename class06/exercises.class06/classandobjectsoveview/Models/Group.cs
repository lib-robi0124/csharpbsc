namespace classesandobjectoveview.Models
{
    public class Group
    {
        public Group()
        {

        }
        public string Name { get; set; }
        public int NumberOfStudents { get; set; }
        public string ClassRoomName { get; set; }

        public Group(string name, int numberofstrudents, string classroomname)
        {
            Name = name;
            NumberOfStudents = numberofstrudents;
            ClassRoomName = classroomname;
        }
    }
}
