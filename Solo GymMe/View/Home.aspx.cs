using Solo_GymMe.Controller;
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
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //MsUser user = Session["User"] as MsUser;
            MsUser user = null;
            if (!IsPostBack)
            {
                if (Session["User"] == null && Request.Cookies["user_cookie"] == null)
                {
                    Response.Redirect("~/View/Login.aspx");
                }
                else
                {
                    if (Session["User"] == null)
                    {
                        string strID = Request.Cookies["user_cookie"].Value;
                        int userID = int.Parse(strID);
                        user = UserController.GetUserID(userID);
                        Session["User"] = user;
                    }

                    string role = GetCurrentUserRole();
                    //lblRole.Text = $"Your role is {role}";

                    //if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                    //{
                    //    CustomerGV.Visible = true;
                    //    LoadCustomerData();
                    //}
                }
            }
        }

        private string GetCurrentUserRole()
        {
            MsUser user = Session["User"] as MsUser;
            if (user != null)
            {
                return user.UserRole;
            }
            return string.Empty;
        }

        //private void LoadCustomerData()
        //{
        //    var customers = UserRepository.GetAllCustomers();
        //    CustomerGV.DataSource = customers;
        //    CustomerGV.DataBind();
        //}
    }
}