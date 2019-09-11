//Data_Layer Class for SQL Functionality
//Programmed by: Markus Reynolds
//08/31/2019

using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EvasWebsite.Data;
using System.Text;
using EvasWebsite;

namespace EvasWebsite.Pages
{
    public partial class Store : Page
    {
        Product product = new Product(); /* object of product record */

        Product_Functions product_functions = new Product_Functions(); /* functions of product */

        protected void Page_Load(object sender, EventArgs e)
        {
            stockStore();
        }

        public void stockStore()
        {
            try
            {
                lblError.Visible = false;
                mainStore.Text = "<div class = 'row'> <div class = 'col-sm-4'>";
                foreach (Product item in Product_Functions.getProduct())
                {
                    mainStore.Text += (product_functions.displayProducts(item.Title
                        , item.Description
                        , item.Quantity
                        , item.Cost
                        , item.PicturePath));
                }
            }
            catch (Exception ex)
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