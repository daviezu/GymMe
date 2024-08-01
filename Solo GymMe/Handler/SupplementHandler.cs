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
    }
}