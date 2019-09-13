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

        /* create the objects */
        Record_Product product = new Record_Product(); /* object of product record */

        Functions_Product product_functions = new Functions_Product(); /* functions of product */
        /*end objects */
        

        protected void Page_Load(object sender, EventArgs e)
        {
            stockStore();
        }


        /*fill up the website with items */
        public void stockStore()
        {
            try
            {
                lblError.Visible = false;
                foreach (Record_Product item in Functions_Product.getProduct())
                {
                    mainStore.Text += (Functions_Product.displayProducts(
                          item.Title
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