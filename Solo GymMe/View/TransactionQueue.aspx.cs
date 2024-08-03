using Solo_GymMe.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Solo_GymMe.View
{
    public partial class TransactionQueue : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RefreshQueue();
            }
        }

        private void RefreshQueue()
        {
            QueueGV.DataSource = OrderController.GetAllTransaction();
            QueueGV.DataBind();
        }

        protected void btnHandleTransaction_Click(object sender, EventArgs e)
        {
            Button btnOrder = (Button)sender;
            GridViewRow row = (GridViewRow)btnOrder.NamingContainer;

            int transactionID = Convert.ToInt32(QueueGV.DataKeys[row.RowIndex].Value);
            OrderController.UpdateStatus(transactionID);

            RefreshQueue();
        }
    }
}