using Solo_GymMe.Handler;
using Solo_GymMe.Model;
using Solo_GymMe.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solo_GymMe.Controller
{
    public class UserController
    {
        public static string ValidateUpdateProfile(string username, string email, string gender, string dob)
        {
            if (string.IsNullOrEmpty(username))
            {
                return "Username cannot be empty";
            }

            if (username.Length < 5 || username.Length > 15)
            {
                return "Username length must be between 5 and 15";
            }

            if (string.IsNullOrEmpty(email))
            {
                return "Email cannot be empty";
            }

            if (!email.EndsWith(".com"))
            {
                return "Email must ends with .com";
            }

            if (string.IsNullOrEmpty(gender))
            {
                return "Gender must be chosen";
            }

            if (!DateTime.TryParse(dob, out DateTime dateOfBirth))
            {
                return "Invalid date of birth";
            }

            return null;
        }

        public static string ValidateUpdatePassword(string oldPassword, string newPassword)
        {
            if (string.IsNullOrEmpty(oldPassword))
            {
                return "Password cannot be empty";
            }

            if (string.IsNullOrEmpty(newPassword))
            {
                return "New password cannot be empty";
            }

            if (oldPassword != newPassword)
            {
                return "Password do not match";
            }
            return null;
        }
        public static string UpdateUserProfile(int userID, string username, string email, string gender, DateTime dob)
        {
            return UserHandler.UpdateUserProfile(userID, username, email, gender, dob);
        }

        public static string UpdateUserPassword(int userID, string oldPassword, string newPassword)
        {
            return UserHandler.UpdateUserPassword(userID, oldPassword, newPassword);
        }

        public static string InsertUser(string username, string email, DateTime dob, string gender, string role, string password)
        {
            return UserHandler.InsertUser(username, email, dob, gender, role, password);
        }
        public static MsUser GetUserID(int userID)
        {
            return UserHandler.GetUserID(userID);
        }
    }
}