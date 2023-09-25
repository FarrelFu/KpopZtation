using KpopZtation.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnregis_Click(object sender, EventArgs e)
        {
            string name = txtemail.Text;
            string email = txtemail.Text;
            string gen = null;
            if (RadioButton1.Checked)
            {
                gen = "Male";
                RadioButton2.Checked = false;
            } 
            else if (RadioButton2.Checked)
            {
                gen = "Female";
                RadioButton1.Checked = false;
            }
            string add = txtadd.Text;
            string pass = txtpass.Text;

            if (customercont.addCustomer(name, email, pass, gen, add))
            {
                Response.Redirect("login.aspx");
            } else
            {
                lblerror.Text = "anda salah";
                txtname.Text = "";
                txtemail.Text = "";
                txtpass.Text = "";
                txtadd.Text = "";
                RadioButton2.Checked = false;
                RadioButton1.Checked = false;
            }
        }
    }
}