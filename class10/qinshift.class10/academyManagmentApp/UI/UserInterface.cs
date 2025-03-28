using AcademyLManagementDomain.Enums;
using AcademyLManagementDomain.Models;
using AcademyManagementServices.UserServices;
using AcademyManagementServices;




namespace academyManagmentApp.UI
{
    public class UserInterface
    {
        private AdminService _adminService { get; set; }
        private TrainerService _trainerService { get; set; }
        private StudentService _studentService { get; set; }

        private ValidationService _validationService { get; set; }
        public UserInterface()
        {
            _adminService = new AdminService();
            _validationService = new ValidationService();
            _trainerService = new TrainerService();
            _studentService = new StudentService();
        }
        public bool IntApp()
        {
            try
            {
                WelcomeMenu();
                int choice = _validationService.GetValidationOption(new int[] { 1, 2, 3 });

                Console.Clear();
                WriteInColor($"Welcome {(Role)choice}.Enter your credentials:\n", ConsoleColor.DarkCyan);
                WriteInColor("Username: ", ConsoleColor.Cyan);
                string username = _validationService.GetStringInput();
                WriteInColor("Password: ", ConsoleColor.Cyan);
                string password = _validationService.GetStringInput();
                Console.ResetColor();

                switch ((Role)choice)
                {
                    case Role.Admin:
                        Admin loggedadmin = _adminService.AdminLogin(username, password);
                        WriteInColor($"Welcome {loggedadmin.GetFullName()}", ConsoleColor.Green);
                        break;
                    case Role.Trainer:
                        Trainer loggedTrainer = _trainerService.TrainerLogin(username, password);
                        WriteInColor($"Welcome {loggedTrainer.GetFullName()}", ConsoleColor.Green);
                        break;
                    case Role.Student:
                        Student loggedStudent = _studentService.StudentLogin(username, password);
                        WriteInColor($"Welcome {loggedStudent.GetFullName()}", ConsoleColor.Green);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                WriteInColor(ex.Message, ConsoleColor.Red);
            }
            return false;
        }
        public void WelcomeMenu()
        {
            Console.WriteLine("Welcome to the Academy Management App", ConsoleColor.DarkCyan);
            Console.WriteLine("\nPlease select your role to login: \n1.Admin \n2.Trainer \n3.Student", ConsoleColor.Cyan);
        }
        public void WriteInColor(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
