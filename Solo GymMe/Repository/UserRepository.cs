using Solo_GymMe.Controller;
using Solo_GymMe.Factory;
using Solo_GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solo_GymMe.Repository
{
    public class UserRepository
    {
        static LocalDatabaseEntities db = Singleton.GetInstance();

        public static string InsertUser(string username, string email, DateTime dob, string gender, string role, string password)
        {
            MsUser newUser = UserFactory.createUser(username, email, dob, gender, role, password);  
            db.MsUsers.Add(newUser);
            db.SaveChanges();
            return "Registration Success";
        }
        public static MsUser GetUserByID(int userID)
        {
            return (from user in db.MsUsers where user.UserID == userID select user).FirstOrDefault();
        }
        public static bool UpdateUserProfile(int userID, string username, string email, string gender, DateTime dob)
        {
           MsUser currentUser = GetUserByID(userID);
            if(currentUser != null)
            {
                currentUser.UserName = username;
                currentUser.UserGender = gender;
                currentUser.UserDOB = dob;
                currentUser.UserEmail = email;

                db.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool UpdateUserPassword(int userID, string oldPassword, string newPassword)
        {
            MsUser currentUser = GetUserByID(userID);
            if(currentUser != null)
            {
                currentUser.UserPassword = newPassword;
                db.SaveChanges();
                return true;    
            }
            return false;
        }
    }
}