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
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadUserProfile();
            }
        }

        private void LoadUserProfile()
        {
            MsUser user = Session["User"] as MsUser;
            if (user != null)
            {
                txtUsername.Text = user.UserName;
                txtEmail.Text = user.UserPassword;
                ddlGender.SelectedValue = user.UserGender;
                txtDOB.Text = user.UserDOB.ToString("dd MMMM yyyy");
                txtOldPassword.Text = user.UserPassword;
            }
            else Response.Redirect("~/View/Login.aspx");
        }
        //protected void calDOB_SelectionChanged(object sender, EventArgs e)
        //{
        //    DateTime date = calDOB.SelectedDate;
        //    txtDOB.Text = date.ToString("dd MMMM yyyy");
        //}

        protected void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            MsUser user = Session["User"] as MsUser;
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string gender = ddlGender.SelectedValue;
            string dob = txtDOB.Text;

            string validationMessage = UserController.ValidateUpdateProfile(username, email, gender, dob);

            lblMessage.Text = "nikadiwkijfa";
            if (validationMessage == null)
            {
                lblMessage.Text = "xoxaowoawdoaw";
                int userID = user.UserID;
                DateTime dt = Convert.ToDateTime(dob);

                string statusMessage = UserController.UpdateUserProfile(userID, username, email, gender, dt);
                lblMessage.Text = statusMessage;

            }
            else lblMessage.Text = validationMessage;
        }

        protected void btnUpdatePassword_Click(object sender, EventArgs e)
        {

        }
    }
}