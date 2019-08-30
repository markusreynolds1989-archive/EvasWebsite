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
            Response.Write(Session["addedItem"]);
            var product = new Product();
            product.displayProducts();
            mainStore.Text = display
        }
    }
}