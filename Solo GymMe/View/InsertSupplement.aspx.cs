using Solo_GymMe.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Solo_GymMe.View
{
    public partial class InsertSupplement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void calDOB_SelectionChanged(object sender, EventArgs e)
        {
            DateTime date = calDOB.SelectedDate;
            txtExpDate.Text = date.ToString("dd MMMM yyyy");
        }

        protected void btnInput_Click(object sender, EventArgs e)
        {
            string name = txtSupplementName.Text;
            string expDateStr = txtExpDate.Text;
            string priceStr = txtSupplementPrice.Text;
            string suppTypeIDStr = txtTypeID.Text;

            string validationMessage = SupplementController.ValidateSupplement(name, priceStr, expDateStr, suppTypeIDStr);
            if (validationMessage == null)
            {
                DateTime expDate = Convert.ToDateTime(expDateStr);
                int price = Convert.ToInt32(priceStr);
                int suppTypeID = Convert.ToInt32(suppTypeIDStr);
                if (Page.IsValid)
                {
                    lblMessage.Text = SupplementController.InsertSupplement(name, price, expDate, suppTypeID);
                }

            }
            else lblMessage.Text = validationMessage;
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ManageSupplement.aspx");
        }
    }
}