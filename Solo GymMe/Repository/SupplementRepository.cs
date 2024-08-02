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

        public static MsSupplement GetSupplementByID(int suppID)
        {
            return (from supp in db.MsSupplements where supp.SupplementID == suppID select supp).FirstOrDefault();
        }

        public static bool UpdateSupplement(int suppID, string suppName, int price, DateTime expiryDate, int suppTypeID)
        {
            MsSupplement updateSupplement = GetSupplementByID(suppID);
            if(updateSupplement != null)
            {
                updateSupplement.SupplementName = suppName;
                updateSupplement.SupplementPrice = price;
                updateSupplement.SupplementExpiryDate = expiryDate;
                updateSupplement.SupplementTypeID = suppTypeID;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public static List<MsSupplement> GetAllSupplement()
        {
            return db.MsSupplements.ToList();
        }

        public static bool DeleteSupplement(int id)
        {
            MsSupplement toDeleteSupplement = GetSupplementByID(id);
            if(toDeleteSupplement != null)
            {
                db.MsSupplements.Remove(toDeleteSupplement);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}