using System.Text.RegularExpressions;

namespace classesandobjectoveview.Models
{
    public class Academy
    {
        public Academy()
        {

        }
        public string Name { get; set; }
        public string Description { get; set; }

        public Academy(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public Group[] Groups { get; set; }

    }
}
