
using AcademyLManagementDomain;
using AcademyLManagementDomain.Enums;
using AcademyLManagementDomain.Models;

namespace AcademyManagementServices.UserServices
{
    public class AdminService
    {
        private DataAccess _dataAccess { get; set; }
        public AdminService()
        {
            _dataAccess = new DataAccess();
        }

        //login
        public Admin AdminLogin(string username, string password)
        {
            Admin adminFromDb = _dataAccess.GetAdmin(username, password);
            if (adminFromDb == null)
            {
                throw new Exception("Invalid credentials");
            }
           return adminFromDb;
        }

        //create user
        public void CreateUser(string username, string password, Role role)
        {
            bool userExists = _dataAccess.CheckIfUserExists(username, role);
            if (userExists)
            {
                throw new Exception($@"{role} with ""{username}"" already exists");
            }
            _dataAccess.CreateNewUser(username, password, role);
        }

        // getUsersToRemove
        public List<string> GetUsersToRemove(Role role, Admin loggedAdmin)
        {
            return _dataAccess.GetUsernames(role, loggedAdmin);
        }

        //remove user
        public void RemoveUser(string username, Role role)
        {
           bool userExists = _dataAccess.CheckIfUserExists(username, role);
            if (!userExists)
            {
                throw new Exception($@"{role} with ""{username}"" does not exist");
            }
            _dataAccess.DeleteUser(username, role);
        }
    }
}
