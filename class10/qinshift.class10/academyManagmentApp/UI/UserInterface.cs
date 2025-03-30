using AcademyLManagementDomain.Enums;
using AcademyLManagementDomain.Models;
using AcademyManagementServices.UserServices;
using AcademyManagementServices;
using AcademyLManagementDomain;




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
                        HandleAdminActions(username, password);
                        break;
                    case Role.Trainer:
                        HandleTrainerActions(username, password);
                        break;
                    case Role.Student:
                        HandleStudentActions(username, password);
                        break;
                    default:
                        break;
                }
                return true;
            }
            catch (Exception ex)
            {
                WriteInColor(ex.Message, ConsoleColor.Red);
                return false;
            }
        }
        private void HandleAdminActions(string username, string password)
        {
            Admin loggedAdmin = _adminService.AdminLogin(username, password);
            WriteInColor($"Welcome {loggedAdmin.GetFullName()} (Admin)", ConsoleColor.Green);
            while (true)
            {

                WriteInColor($"Choice what will do: \n1. Create User\n2. Remove User\n3. Logout", ConsoleColor.DarkCyan);
                int choice = _validationService.GetValidationOption(new int[] { 1, 2, 3 });

                if (choice == 3) break;

                WriteInColor("Enter Username: (to edit) ", ConsoleColor.Cyan);
                 string userToModify = _validationService.GetStringInput();
                WriteInColor("Enter role (for UserEdit)(1-Admin, 2-Trainer, 3-Student): ", ConsoleColor.Cyan);
                Role role = (Role)_validationService.GetValidationOption(new int[] { 1, 2, 3 });

                if (choice == 1)
                {
                    Console.Write("Enter password: ");
                    string newPassword = _validationService.GetStringInput();
                    _adminService.CreateUser(userToModify, newPassword, role);
                    Console.WriteLine("User created successfully!");
                }
                else if (choice == 2)
                {
                    _adminService.RemoveUser(userToModify, role);
                    Console.WriteLine("User removed successfully!");
                }
            }
        }
        private void HandleTrainerActions(string username, string password)
        {
            Trainer loggedTrainer = _trainerService.TrainerLogin(username, password);
            WriteInColor($"Welcome {loggedTrainer.GetFullName()} (Trainer)", ConsoleColor.Green);

            while (true)
            {
                Console.WriteLine("1. View Students\n2. View Subjects\n3. Logout");
                int choice = _validationService.GetValidationOption(new int[] { 1, 2, 3 });

                if (choice == 3) break;

                if (choice == 1)
                {
                    var students = _trainerService.GetTrainerUsers(Role.Student, loggedTrainer);
                    students.ForEach(s => Console.WriteLine(s));
                }
                else if (choice == 2)
                {
                    Dictionary<string, int> subjects = _trainerService.SubjectsWithStudentCounts;
                    foreach (var subject in subjects)
                    {
                        Console.WriteLine($"{subject.Key}: {subject.Value} students");
                    }
                }
            }
        }
        private void HandleStudentActions(string username, string password)
        {
            Student loggedStudent = _studentService.StudentLogin(username, password);
            WriteInColor($"Welcome {loggedStudent.GetFullName()} (Student)", ConsoleColor.Green);
            Console.WriteLine($"Current Subject: {loggedStudent.CurrentSubject}");
            Console.WriteLine("Grades:");
            foreach (var grade in loggedStudent.SubjectGrade)
            {
                Console.WriteLine($"{grade.Key}: {grade.Value}");
            }
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
