using Solo_GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solo_GymMe.Controller
{
    public class RegisterController
    {
        public static string ValidateRegister(string username, string email, string gender, string password, string confirmPassword, string dob)
        {
            if (string.IsNullOrEmpty(username))
            {
                return "Username cannot be empty";
            }

            if (username.Length < 5 || username.Length > 15)
            {
                return "Username length must be between 5 and 15";
            }

            if(string.IsNullOrEmpty(email))
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

            if (string.IsNullOrEmpty(password))
            {
                return "Password cannot be empty";
            }

            if (string.IsNullOrEmpty(confirmPassword))
            {
                return "Confirm password cannot be empty";
            }

            if(password != confirmPassword)
            {
                return "Password do not match"; 
            }

            if (!DateTime.TryParse(dob, out DateTime dateOfBirth))
            {
                return "Invalid date of birth";
            }

            return null;
        }
        
    }
}