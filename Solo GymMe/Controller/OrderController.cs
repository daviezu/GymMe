using Solo_GymMe.Handler;
using Solo_GymMe.Model;
using Solo_GymMe.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solo_GymMe.Controller
{
    public class OrderController
    {
        public static List<TransactionHeader> GetAllTransaction()
        {
            return OrderHandler.GetAllTransactionHeader();
        }
    }
}