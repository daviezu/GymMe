using Solo_GymMe.Controller;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Solo_GymMe.View
{
    public partial class ManageSupplement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RefreshSupplement();
            }
        }

        private void RefreshSupplement()
        {
            ManageSuppGV.DataSource = SupplementController.GetAllSupplement();
            ManageSuppGV.DataBind();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/InsertSupplement.aspx");
        }

        protected void ManageSuppGV_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            if (ManageSuppGV.DataKeys != null && ManageSuppGV.DataKeys[e.RowIndex].Value != null)
            {
                int suppID = Convert.ToInt32(ManageSuppGV.DataKeys[e.RowIndex].Value);
                Debug.WriteLine(suppID);
                Response.Redirect("~/View/UpdateSupplement.aspx?SupplementID=" + suppID);
            }
            else lblMessage.Text = "Not valid credentials";
        }

        protected void ManageSuppGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int suppID = Convert.ToInt32(ManageSuppGV.DataKeys[e.RowIndex].Value);
            lblMessage.Text = SupplementController.DeleteSupplement(suppID);
            // Refresh after deleting
            RefreshSupplement();
        }
    }
}