using Solo_GymMe.Controller;
using Solo_GymMe.Factory;
using Solo_GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solo_GymMe.Repository
{
    public class CartRepository
    {
        static LocalDatabaseEntities db = Singleton.GetInstance();
        public static bool insertCart(int userID, int suppID, int quantity)
        {
            bool checkCart = CheckSameCart(userID, suppID, quantity);
            if (checkCart)
            {
                return false;
            }
            MsCart newCart = CartFactory.createCart(userID, suppID, quantity);
            if (newCart != null)
            {
                db.MsCarts.Add(newCart);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public static List<MsCart> GetCartByUserID(int userID)
        {
            return (from user in db.MsCarts where user.UserID == userID select user).ToList();
        }

        public static bool CheckSameCart(int suppID, int userID, int quantity)
        {
            MsCart CartToCheck = (from cart in db.MsCarts where cart.SupplementID == suppID && cart.UserID == userID select cart).FirstOrDefault();
            if (CartToCheck != null)
            {
                CartToCheck.Quantity += quantity;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public static bool ClearCart(int userID)
        {
            var cartList = db.MsCarts.Where(c => c.UserID == userID).ToList();
            if (cartList != null)
            {
                db.MsCarts.RemoveRange(cartList);
                db.SaveChanges();
                return true;
            }
            return false;
        }


        public static bool DeleteCart(MsCart cart)
        {
            if(cart != null)
            {
                db.MsCarts.Remove(cart);
                db.SaveChanges();
                return true;
            }
            return false;
        }

    }
}