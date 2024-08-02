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
    public partial class OrderSupplement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                RefreshSupplement();
            }
        }

        private void RefreshSupplement()
        {
            OrderSuppGV.DataSource = SupplementController.GetAllSupplement();
            OrderSuppGV.DataBind();
        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            Button btnOrder = (Button)sender;   
            GridViewRow row = (GridViewRow)btnOrder.NamingContainer;
            TextBox txtQuantity = (TextBox)row.FindControl("txtQuantity");

            string validationMessage = CartController.ValidateQuantity(txtQuantity.Text);
            if(validationMessage == null)
            {
                //accesing supplement
                //string name = row.Cells[0].Text;
                //DateTime expDate = Convert.ToDateTime(row.Cells[1].Text);
                //int price = Convert.ToInt32(row.Cells[2].Text);
                //int typeID = Convert.ToInt32(row.Cells[3].Text);

                // storing in cart
                int suppID = Convert.ToInt32(OrderSuppGV.DataKeys[row.RowIndex].Value);
                MsUser getUser = Session["User"] as MsUser;
                int userID = getUser.UserID;
                int quantity = Convert.ToInt32(txtQuantity.Text);

                // insert to cart

                lblMessage.Text = CartController.insertCart(userID, suppID, quantity);
            }
            else lblMessage.Text = validationMessage;   
        }
    }
}