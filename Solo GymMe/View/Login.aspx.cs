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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text; 
            bool rememberMe = chkRememberMe.Checked;

            string validationMessage = LoginController.ValidateLogin(username, password);
            if(validationMessage == null)
            {
                MsUser checkUser = LoginController.CheckUserLogin(username, password);
                if (checkUser != null)
                {
                    Session["User"] = checkUser;
                    if(rememberMe)
                    {
                        HttpCookie cookie = new HttpCookie("user_cookie");
                        cookie.Value = checkUser.UserID.ToString();
                        cookie.Expires = DateTime.Now.AddHours(1);
                        Response.Cookies.Add(cookie);
                    }
                    Response.Redirect("~/View/Home.aspx");
                }
                else lblMessage.Text = "User doesn't exist";
            }
            else lblMessage.Text = validationMessage;
        }
    }
}