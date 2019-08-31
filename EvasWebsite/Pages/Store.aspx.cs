using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EvasWebsite.Data;

namespace EvasWebsite.Pages
{
    public partial class Store : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string html = Session["addedItem"].ToString();
                mainStore.Text = html;
            }
            catch
            {
                lblError.Text = "No products are available to display at this time.";
            }
        }
    }
}