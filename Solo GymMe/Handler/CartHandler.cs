﻿using Solo_GymMe.Factory;
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
        public static void checkInsertCart(int userID, int suppID, int quantity)
        {
            CartRepository.checkInsertCart(userID, suppID, quantity);
        }

        public static List<MsCart> GetCartByUserID(int userID)
        {
            return CartRepository.GetCartByUserID(userID);
        }

        public static string ClearCart(int userID)
        {
            return CartRepository.ClearCart(userID) ? "Clear cart complete." : "Failed to clear cart";
        }

        public static string DeleteCart(MsCart cart)
        {
            return CartRepository.DeleteCart(cart) ? "Cart deleted succesfully." : "Failed to delete cart.";
        }
    }
}