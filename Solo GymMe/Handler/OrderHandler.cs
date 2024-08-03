using Solo_GymMe.Model;
using Solo_GymMe.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solo_GymMe.Handler
{
    public class OrderHandler
    {
        public static List<TransactionHeader> GetAllTransactionHeader()
        {
            return TransactionRepository.GetAllTransactionHeader();
        }
    }
}