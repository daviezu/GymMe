using Solo_GymMe.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Solo_GymMe.View.Master
{
    public partial class Template : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MsUser user = Session["User"] as MsUser;
                if (user != null)
                {
                    string role = user.UserRole;
                    if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                    {
                        adminNav.Visible = true;
                    }
                    else customerNav.Visible = true;
                }
                else Response.Redirect("~/View/Home.aspx");
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            string[] cookies = Request.Cookies.AllKeys;
            foreach (string cookie in cookies)
            {
                if (Request.Cookies[cookie] != null)
                {
                    HttpCookie expiredCookie = new HttpCookie(cookie)
                    {
                        Expires = DateTime.Now.AddDays(-1)
                    };
                    Response.Cookies.Add(expiredCookie);
                }
            }
            Session.Remove("User");
            Response.Redirect("~/View/Login.aspx");
        }
    }
}