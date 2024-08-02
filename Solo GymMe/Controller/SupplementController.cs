using Solo_GymMe.Handler;
using Solo_GymMe.Model;
using Solo_GymMe.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Solo_GymMe.Controller
{
    public class SupplementController
    {
        public static string InsertSupplement(string suppName, int price, DateTime expiryDate, int suppTypeID)
        {
            return SupplementHandler.InsertSupplement(suppName, price, expiryDate, suppTypeID);
        }

        public static string ValidateSupplement(string suppName, string price, string expDate, string suppTypeID)
        {
            if(string.IsNullOrEmpty(suppName))
            {
                return "Name cannot be empty";
            }

            if (!suppName.Contains("Supplement"))
            {
                return "Must contain 'Supplement'.";
            }

            if (!DateTime.TryParse(expDate, out DateTime dateOfBirth))
            {
                return "Invalid expired date.";
            }

            if(dateOfBirth < DateTime.Now)
            {
                return "Date must be greater than today";
            }

            if (string.IsNullOrEmpty(price))
            {
                return "Price cannot be empty.";
            }
            
            if (Convert.ToInt32(price) < 3000)
            {
                return "Price must be atleast 3000.";
            }

            if(string.IsNullOrEmpty(suppTypeID))
            {
                return "Type ID cannot be empty.";
            }

            if (!int.TryParse(suppTypeID, out int typeId))
            {
                return "Type ID must be a valid number";
            }

            return null;
        }

        public static string UpdateSupplement(int suppID, string suppName, int price, DateTime expiryDate, int suppTypeID)
        {
            return SupplementHandler.UpdateSupplement(suppID, suppName, price, expiryDate, suppTypeID);
        }

        public static List<MsSupplement> GetAllSupplement()
        {
            return SupplementHandler.GetAllSupplement();
        }

        public static string DeleteSupplement(int id)
        {
            return SupplementHandler.DeleteSupplement(id);
        }
    }
}