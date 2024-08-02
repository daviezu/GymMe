using Solo_GymMe.Handler;
using Solo_GymMe.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solo_GymMe.Controller
{
    public class CartController
    {
        public static string ValidateQuantity(string quantity)
        {
            if (string.IsNullOrEmpty(quantity))
            {
                return "Quantity must be bigger than 0";
            }
            return null;
        }

        public static string insertCart(int userID, int suppID, int quantity)
        {
            return CartHandler.insertCart(userID, suppID, quantity);
        }
    }
}