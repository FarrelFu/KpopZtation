using KpopZtation.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class UpdateProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request.QueryString["id"]);
                Customer customer = customercont.getCustomerbyID(2);

                txtProfile_Name.Text = customer.CustomerName;
                txtProfile_Address.Text = customer.CustomerAddress;
                txtProfile_Email.Text = customer.CustomerEmail;
                txtProfile_Password.Text = customer.CustomerPassword;
                if(customer.CustomerGender == "Male")
                {
                    Male.Checked = true;
                } else if(customer.CustomerGender == "Female")
                {
                    Female.Checked = true;
                }
            }
        }

        protected void BtnProfile_Update_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            string gender = null;
            if (Male.Checked == true)
            {
                gender.Equals("Male");
                Female.Checked = false;
            }
            else if (Female.Checked == true)
            {
                gender.Equals("Female");
                Male.Checked = false;
            }
            if (customercont.updateProfile(2, txtProfile_Name.Text, txtProfile_Email.Text, gender, txtProfile_Address.Text, txtProfile_Password.Text))
            {
                Response.Redirect("Home.aspx");
            } else
            {
                lblProfile_Msg.Text = "Terdapat data yang salah";
            }
        }

        protected void btnback_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}