using Solo_GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solo_GymMe.Controller
{
    public class Singleton
    {
        public static LocalDatabaseEntities instance;

        public static LocalDatabaseEntities GetInstance()
        {
            if(instance == null)
            {
                instance = new LocalDatabaseEntities();
            }
            return instance;
        }
    }
}