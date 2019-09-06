using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EvasWebsite.Pages.ProductManagement
{
    public partial class Product_Management : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SecurityLevel"] != "0")
            {
                Response.Redirect("~/Pages/Login/Login_Admin.aspx");
            }
        }
    }
}