using Microsoft.VisualBasic;

namespace exercises.class06.Models
{
    public class User
    {
        public User()
        {

        }
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string[] Message { get; set; }


      public User(int iD, string username, string password, string[] message)
        {
            ID = iD;
            Username = username;
            Password = password;
            Message = message;
        }
    }
}


