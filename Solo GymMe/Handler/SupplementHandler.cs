using Solo_GymMe.Factory;
using Solo_GymMe.Model;
using Solo_GymMe.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solo_GymMe.Handler
{
    public class SupplementHandler
    {
        public static string InsertSupplement(string suppName, int price, DateTime expiryDate, int suppTypeID)
        {
            return SupplementRepository.InsertSupplement(suppName, price, expiryDate, suppTypeID);
        }

        public static string UpdateSupplement(int suppID, string suppName, int price, DateTime expiryDate, int suppTypeID)
        {
            return SupplementRepository.UpdateSupplement(suppID, suppName, price, expiryDate, suppTypeID) ? "Supplement updated succesfully" : "Failed to update supplement";
        }

        public static List<MsSupplement> GetAllSupplement()
        {
            return SupplementRepository.GetAllSupplement();
        }

        public static string DeleteSupplement(int id)
        {  
            return SupplementRepository.DeleteSupplement(id) ? "Supplement deleted succesfully" : "Failed to delete supplement.";
        }

        public static MsSupplement GetSupplementByID(int suppID)
        {
            return SupplementRepository.GetSupplementByID(suppID);
        }
    }
}