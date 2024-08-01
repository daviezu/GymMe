using Solo_GymMe.Controller;
using Solo_GymMe.Factory;
using Solo_GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace Solo_GymMe.Repository
{
    public class SupplementRepository
    {
        static LocalDatabaseEntities db = Singleton.GetInstance();
        public static string InsertSupplement(string suppName, int price, DateTime expiryDate, int suppTypeID)
        {
            MsSupplement newSupplement = SupplementFactory.createSupplement(suppName, price, expiryDate, suppTypeID);
            db.MsSupplements.Add(newSupplement);
            db.SaveChanges();
            return "New Supplement insertion completed";
        }
    }
}