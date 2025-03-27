namespace qinshift.errorhandle.Models
{
    public class Human
    {
        public Human()
            {
              Skills = new List<Skill>();
            }
        public string Name { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
