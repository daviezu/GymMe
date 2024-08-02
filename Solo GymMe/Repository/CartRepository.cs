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
            MsCart newCart = CartFactory.createCart(userID, suppID, quantity);
            if (newCart != null)
            {
                db.MsCarts.Add(newCart);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}