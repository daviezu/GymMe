using Solo_GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solo_GymMe.Factory
{
    public class SupplementFactory
    {
        public static MsSupplement createSupplement(string suppName, int price, DateTime expiryDate, int suppTypeID)
        {
            MsSupplement newSupplement = new MsSupplement()
            {
                SupplementName = suppName,
                SupplementExpiryDate = expiryDate,
                SupplementPrice = price,
                SupplementTypeID = suppTypeID,
            };
            return newSupplement;
        }
    }
}