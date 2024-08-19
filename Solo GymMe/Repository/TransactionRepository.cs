using Solo_GymMe.Controller;
using Solo_GymMe.Factory;
using Solo_GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solo_GymMe.Repository
{
    public class TransactionRepository
    {
        static LocalDatabaseEntities db = Singleton.GetInstance();
        public static TransactionHeader InsertTransactionHeader(int userID, DateTime tDate, string status)
        {
            TransactionHeader newTH = TransactionFactory.CreateTransactionHeader(userID, tDate, status);
            db.TransactionHeaders.Add(newTH);
            db.SaveChanges();
            return newTH;
        }

        public static TransactionDetail InsertTransactionDetail(int transactionID, int suppID, int quantity)
        {
            TransactionDetail newTD = TransactionFactory.CreateTransactionDetail(transactionID, suppID, quantity);
            db.TransactionDetails.Add(newTD);
            db.SaveChanges();
            return newTD;
        }

        public static bool MakeTransaction(int userID)
        {
            var cartItem = CartController.GetCartByUserID(userID);
            if(cartItem != null)
            {
                DateTime currTime = DateTime.Now;
                string status = "unhandled";
                // Create transaction header
                TransactionHeader th = InsertTransactionHeader(userID, currTime, status);

                foreach(var cart in cartItem)
                {
                    TransactionDetail td = InsertTransactionDetail(th.TransactionID, cart.SupplementID, cart.Quantity);
                    CartController.DeleteCart(cart);
                }
                return true;
            }
            return false;
        }

        public static List<TransactionHeader> GetAllTransactionHeader()
        {
            return db.TransactionHeaders.ToList();
        }

        public static List<TransactionDetail> GetTransactionDetailByID(int transactionID)
        {
            return (from td in db.TransactionDetails where td.TransactionID == transactionID select td).ToList();
        }

        public static TransactionHeader GetTransactionHeaderByID(int transactionID)
        {
            return (from th in db.TransactionHeaders where th.TransactionID == transactionID select th).FirstOrDefault();
        }

        public static void UpdateStatus(int transactionID)
        {
            TransactionHeader t = GetTransactionHeaderByID(transactionID);
            if(t != null)
            {
                t.Status = "handled";
                db.SaveChanges();
            }
        }
    }
}