using Solo_GymMe.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Solo_GymMe.View
{
    public partial class TransactionHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TransactionHistoryGV.DataSource = OrderController.GetAllTransaction();
                TransactionHistoryGV.DataBind();
            }
        }

        protected void btnDetail_Click(object sender, EventArgs e)
        {
            Button btnOrder = (Button)sender;
            GridViewRow row = (GridViewRow)btnOrder.NamingContainer;

            int TransactionID = Convert.ToInt32(TransactionHistoryGV.DataKeys[row.RowIndex].Value);
            Response.Redirect("~/View/TransactionDetailPage.aspx?ID="+TransactionID);
        }
    }
}