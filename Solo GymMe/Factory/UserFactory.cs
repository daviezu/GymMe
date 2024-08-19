using Solo_GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solo_GymMe.Factory
{
    public class UserFactory
    {
        public static MsUser createUser(string username, string email, DateTime dob, string gender, string role, string password)
        {
            MsUser newUser = new MsUser()
            {
                UserName = username,
                UserEmail = email,
                UserDOB = dob,
                UserGender = gender,
                UserRole = role,
                UserPassword = password,
            };

            return newUser;
        }
    }
}