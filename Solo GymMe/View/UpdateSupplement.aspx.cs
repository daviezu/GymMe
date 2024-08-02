using Solo_GymMe.Controller;
using Solo_GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Solo_GymMe.View
{
    public partial class UpdateSupplement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void calDOB_SelectionChanged(object sender, EventArgs e)
        //{
        //    DateTime date = calDOB.SelectedDate;
        //    txtExpDate.Text = date.ToString("dd MMMM yyyy");
        //}

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string newName = txtSupplementName.Text;
            string newExpDateStr = txtExpDate.Text;
            string newPriceStr = txtSupplementPrice.Text;
            string newSuppTypeIDStr = txtTypeID.Text;

            string validationMessage = SupplementController.ValidateSupplement(newName, newPriceStr, newExpDateStr, newSuppTypeIDStr);
            if (validationMessage == null)
            {
                int suppID = Convert.ToInt32(Request.QueryString["SupplementID"]);
                DateTime expDate = Convert.ToDateTime(newExpDateStr);
                int price = Convert.ToInt32(newPriceStr);
                int suppTypeID = Convert.ToInt32(newSuppTypeIDStr);
                if (Page.IsValid)
                {
                    lblMessage.Text = SupplementController.UpdateSupplement(suppID, newName, price, expDate, suppTypeID);
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