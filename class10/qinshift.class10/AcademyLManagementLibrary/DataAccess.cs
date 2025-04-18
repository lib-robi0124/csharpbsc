﻿using AcademyLManagementDomain.Enums;
using AcademyLManagementDomain.Models;

namespace AcademyLManagementDomain
{
    public class DataAccess
    {
        private Database _database;
        public DataAccess()
        {
            _database = new Database();
        }
        public Admin GetAdmin(string username, string password)
        {
            Admin adminFromDb = _database.Admins.FirstOrDefault(x => x.Username.ToLower().Trim() == username.ToLower().Trim() && x.Password == password);
            return adminFromDb; 
        }
        public Trainer GetTrainer(string username, string password)
        {
            Trainer trainerFromDb = _database.Trainers.FirstOrDefault(x => x.Username.ToLower().Trim() == username.ToLower().Trim() && x.Password == password);
            return trainerFromDb;
        }
        public Student GetStudent(string username, string password)
        {
            Student studentFromDb = _database.Students.FirstOrDefault(x => x.Username.ToLower().Trim() == username.ToLower().Trim() && x.Password == password);
            return studentFromDb;
        }
        public bool CheckIfUserExists(string username, Role role)
        {
            switch (role)
            {
                case Role.Admin:
                    return _database.Admins.Any(x => x.Username.ToLower().Trim().Trim() == username.ToLower().Trim());
                  
                case Role.Trainer:
                    return _database.Trainers.Any(x => x.Username.ToLower().Trim().Trim() == username.ToLower().Trim());
                    
                case Role.Student:
                    return _database.Students.Any(x => x.Username.ToLower().Trim().Trim() == username.ToLower().Trim());
                    
                default:
                    return false;
            }

        }
        public List<string> GetUsernames(Role role, User loggedUser)
        {
            if (loggedUser == null)
                throw new ArgumentNullException(nameof(loggedUser), "Logged user cannot be null");

            switch (role)
            {
                case Role.Admin when loggedUser is Admin loggedAdmin:
                    //Admin loggedAdmin = (Admin)loggedUser;
                    //if (loggedUser is Admin loggedAdmin)
                    return _database.Admins.Where(x => x.Username != loggedAdmin.Username)
                        .Select(x => x.Username).ToList();
                case Role.Trainer when loggedUser is Trainer loggedTrainer:
                    //Trainer loggedTrainer = (Trainer)loggedUser;
                    //if (loggedUser is Trainer loggedTrainer)
                    return _database.Trainers.Where(x => x.Username != loggedTrainer.Username)
                        .Select(x => x.Username).ToList();
                case Role.Student:
                    //Student loggedStudent = (Student)loggedUser;
                    //if (loggedUser is Student loggedStudent)
                    return _database.Students.Select(x => x.Username).ToList();
                default:
                    throw new Exception("error occured while retriving username from database");
            }
        }
        public void CreateNewUser(string username, string password, Role role)
        {
            switch (role)
            {
                case Role.Admin:
                    Admin newAdmin = new Admin(username, password);
                    _database.Admins.Add(newAdmin);
                    break;
                case Role.Trainer:
                    Trainer newTrainer = new Trainer(username, password);
                    _database.Trainers.Add(newTrainer);
                    break;
                case Role.Student:
                    Student newStudent = new Student(username, password);
                    _database.Students.Add(newStudent);
                    break;
                default:
                    throw new Exception("Error occured while saving new user to Db");
            }
        }
        public bool DeleteUser(string username, Role role)
        {
            switch (role)
            {
                case Role.Admin:
                    Admin adminDb = _database.Admins.FirstOrDefault(x => x.Username.ToLower().Trim() == username.ToLower().Trim());
                    return _database.Admins.Remove(adminDb);
                case Role.Trainer:
                    Trainer trainerDb = _database.Trainers.FirstOrDefault(x => x.Username.ToLower().Trim() == username.ToLower().Trim());
                    return _database.Trainers.Remove(trainerDb);
                case Role.Student:
                    Student studentDb = _database.Students.FirstOrDefault(x => x.Username.ToLower().Trim() == username.ToLower().Trim());
                    return _database.Students.Remove(studentDb);
                default:
                   return false;
            }
        }
    }
}
