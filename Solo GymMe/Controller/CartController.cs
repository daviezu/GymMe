using Solo_GymMe.Handler;
using Solo_GymMe.Model;
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

        public static void checkInsertCart(int userID, int suppID, int quantity)
        {
            CartHandler.checkInsertCart(userID, suppID, quantity);
        }

        public static List<MsCart> GetCartByUserID(int userID)
        {
            return CartHandler.GetCartByUserID(userID);
        }

        public static string ClearCart(int userID)
        {
            return CartHandler.ClearCart(userID);
        }

        public static string DeleteCart(MsCart cart)
        {
            return CartHandler.DeleteCart(cart);
        }

        public static string CheckoutCart(int userID)
        {
            return TransactionRepository.MakeTransaction(userID) ? "Checkout Success" : "Failed to checkout";
        }
    }
}