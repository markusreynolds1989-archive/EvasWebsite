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
    public partial class Store : Page
    {
        Product product = new Product();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                lblError.Visible = false;
                mainStore.Text = product.displayProducts();
            }
            catch(Exception ex)
            {
                lblError.Visible = true;
                lblError.Text = "No products are available to display at this time.";
                Debug.WriteLine
                    ("******ALERT*****\n" +
                    $"{ex}\n" +
                    "******ENDALERT*****\n");
            }
        }
    }
}