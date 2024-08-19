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

        public static void checkInsertCart(int userID, int suppID, int quantity)
        {
            MsCart checkCart = (from c in db.MsCarts where c.UserID == userID && c.SupplementID == suppID select c).FirstOrDefault();
            if(checkCart != null)
            {
                checkCart.Quantity += quantity;
                db.SaveChanges();
            }
            else
            {
                MsCart newCart = CartFactory.createCart(userID, suppID, quantity);
                db.MsCarts.Add(newCart);
                db.SaveChanges();
            }
        }

        public static List<MsCart> GetCartByUserID(int userID)
        {
            return (from user in db.MsCarts where user.UserID == userID select user).ToList();
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
            if (cart != null)
            {
                db.MsCarts.Remove(cart);
                db.SaveChanges();
                return true;
            }
            return false;
        }

    }
}