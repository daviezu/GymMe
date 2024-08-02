using Solo_GymMe.Factory;
using Solo_GymMe.Model;
using Solo_GymMe.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solo_GymMe.Handler
{
    public class CartHandler
    {
        public static string insertCart(int userID, int suppID, int quantity)
        {
            return CartRepository.insertCart(userID, suppID, quantity) ? "Cart inserted succesfully" : "Failed to insert to cart";
        }
    }
}