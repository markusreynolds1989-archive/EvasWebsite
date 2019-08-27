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
            var products = new List<Product>();

            //call the displayProduct method to write the HTML to the page
            foreach (Product product in products)
            {
                //var item = new Product();
                //stuff.InnerHtml = product.displayProduct();
            }

        }
    }
}