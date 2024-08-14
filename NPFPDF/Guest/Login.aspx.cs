using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace productDemandForecasting.Guest
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)

                radiobtnCompany.Checked = true;
        }

        protected void btnSignin_Click(object sender, EventArgs e)
        {
            try
            {
                BLL obj = new BLL();

                if (txtUserId.Value.Equals("Sony") && txtPassword.Value.Equals("123"))
                {


                    Response.Redirect("~/Company/_SingleBPhone.aspx");
                }
                   
                    else
                    {
                        ClientScript.RegisterStartupScript(GetType(), "key", "<script>alert('Invalid id/password!!!')</script>");
                    }
                
                
            }
            catch
            {
                ClientScript.RegisterStartupScript(GetType(), "key", "<script>alert('Server Error - Check the Database Connectivity!!!')</script>");
            }
        }
    }
}