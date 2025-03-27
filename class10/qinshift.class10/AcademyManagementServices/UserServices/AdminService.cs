


namespace AcademyManagementServices.UserServices
{
    public class AdminService
    {
        private DataAccess { get; set; }
      
        //login
        public AdminLogin(string username, string password)
        {
            Admin adminFromDb = _dataAccess.GetAdmin(username, password);
            if (adminFromDb == null)
            {
                throw new Exception("Invalid credentials");
            }
           return adminFromDb;
        }

        //create user
        public void CreateUser(string username, string password)
        {
            bool userExists = _dataAccess.CheckIfUserExisists(username, password);
            if (userExists)
            {
                throw new Exception($@"{role} with ""{username}"" already exists");
            }
            _dataAccess.CreateNewUser(username, password);
        }
        // getUsersToRemove
        public List<string> GetUsersToRemove(WindowsBuiltInRole role, Admin loggedAdmin)
        {
            return _dataAccess.GetUsernames(role, loggedAdmin);
        }


    }
}
