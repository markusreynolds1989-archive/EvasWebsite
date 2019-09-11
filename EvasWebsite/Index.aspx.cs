using EvasWebsite.Data;
using System;
using System.Collections.Generic;

namespace EvasWebsite.Pages
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //create a list of products from the product data class
            var products = new List<Record_Product>();

            //call the displayProduct method to write the HTML to the page
            foreach (Record_Product product in products)
            {
                //var item = new Record_Product();
                //stuff.InnerHtml = product.displayProduct();
            }

        }
    }
}