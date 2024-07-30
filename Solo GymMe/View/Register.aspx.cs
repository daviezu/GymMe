using Solo_GymMe.Controller;
using Solo_GymMe.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Solo_GymMe.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string gender = ddlGender.SelectedValue;
            string password = txtPassword.Text; 
            string confirmPassword = txtConfirmPassword.Text;
            string dob = txtDOB.Text;

            string validationMessage = RegisterController.ValidateRegister(username, email, gender, password, confirmPassword, dob);
            if(validationMessage == null)
            {
                DateTime dt = Convert.ToDateTime(dob);
                if (Page.IsValid)
                {
                    string role = "Customer";
                    lblMessage.Text = UserRepository.InsertUser(username, email, dt, gender, role, password);
                    Response.Redirect("~/View/Login.aspx");
                }
            }
            else lblMessage.Text = validationMessage;
        }

        protected void calDOB_SelectionChanged(object sender, EventArgs e)
        {
            DateTime date = calDOB.SelectedDate;
            txtDOB.Text = date.ToString("dd MMMM yyyy");
        }
    }
}