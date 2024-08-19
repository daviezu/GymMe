using Solo_GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solo_GymMe.Factory
{
    public class CartFactory
    {
        public static MsCart createCart(int userID, int suppID, int quantity)
        {
            MsCart newCart = new MsCart()
            {
                UserID = userID,
                SupplementID = suppID,
                Quantity = quantity
            };
            return newCart;
        }
    }
}