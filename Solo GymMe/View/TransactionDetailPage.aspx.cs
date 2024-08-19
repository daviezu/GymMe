using Solo_GymMe.Model;
using Solo_GymMe.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Solo_GymMe.View
{
    public partial class TransactionDetailPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int tdID = Convert.ToInt32(Request.QueryString["ID"]);
                List<TransactionDetail> tdList = TransactionRepository.GetTransactionDetailByID(tdID);
                TransactionDetailGV.DataSource = tdList;
                TransactionDetailGV.DataBind();
            }
        }
    }
}