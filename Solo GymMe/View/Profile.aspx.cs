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

        }

        protected void calDOB_SelectionChanged(object sender, EventArgs e)
        {
            DateTime date = calDOB.SelectedDate;
            txtDOB.Text = date.ToString("dd MMMM yyyy");
        }

        protected void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            MsUser user = Session["User"] as MsUser;
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string gender = ddlGender.SelectedValue;
            string dob = txtDOB.Text;

            string validationMessage = UserController.ValidateUpdateProfile(username, email, gender, dob);
            if (validationMessage == null)
            {
                int userID = user.UserID;
                DateTime dt = Convert.ToDateTime(dob);

                string statusMessage = UserController.UpdateUserProfile(userID, username, email, gender, dt);

            }
            else lblMessage.Text = validationMessage;
        }

        protected void btnUpdatePassword_Click(object sender, EventArgs e)
        {

        }
    }
}