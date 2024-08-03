using Solo_GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solo_GymMe.Factory
{
    public class TransactionFactory
    {
        public static TransactionHeader CreateTransactionHeader(int userID, DateTime tDate, string status)
        {
            TransactionHeader th = new TransactionHeader()
            {
                UserID = userID,    
                TransactionDate = tDate,
                Status = status
            };
            return th;
        }

        public static TransactionDetail CreateTransactionDetail(int transactionID, int suppID, int quantity)
        {
            TransactionDetail td = new TransactionDetail()
            {
                TransactionID = transactionID,
                SupplementID = suppID,
                Quantity = quantity
            };

            return td;
        }
    }
}