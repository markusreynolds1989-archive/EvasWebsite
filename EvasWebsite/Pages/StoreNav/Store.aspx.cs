using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EvasWebsite.Data;
using System.Text;

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
                mainStore.Text = "<div class = 'row'> <div class = 'col-sm-4'>";
                foreach (Product item in Data_Layer.getProduct())
                {
                    mainStore.Text += (product.displayProducts(item.Title
                        , item.Description
                        , item.Quantity
                        , item.PicturePath));
                }
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