using Solo_GymMe.Model;
using Solo_GymMe.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solo_GymMe.Handler
{
    public class UserHandler
    {
        public static string UpdateUserProfile(int userID, string username, string email, string gender, DateTime dob)
        {
            return UserRepository.UpdateUserProfile(userID, username, email, gender, dob) ? "Profile updated successfully." : "Failed to update profile.";
        }

        public static string UpdateUserPassword(int userID, string oldPassword, string newPassword)
        {
            return UserRepository.UpdateUserPassword(userID, oldPassword, newPassword) ? "Password updated succesfully." : "Failed to update password."; 
        }
    }
}