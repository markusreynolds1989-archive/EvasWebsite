using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EvasWebsite;
using EvasWebsite.Data;

namespace EvasWebsite.Pages.ProductManagement
{
    public partial class Modify_Product : System.Web.UI.Page
    {
        Product product = new Product();
        Product_Functions product_functions = new Product_Functions();

        protected void Page_Load(object sender, EventArgs e)
        {
            productTable.Text = @"
                <thead>
                    <tr>
                        <th scope = 'col'>Commit Modify</th>
                        <th scope = 'col'>Delete</th>
                        <th scope = 'col'>ID</th>
                        <th scope = 'col'>Title</th>
                        <th scope = 'col'>Description</th>
                        <th scope = 'col'>Quantity</th>
                        <th scope = 'col'>Cost</th>
                        <th scope = 'col'>Picture Path</th>
                    </tr>
                </thead>
                <tbody>";
            /*if (Session["SecurityLevel"] != "0")
            {
                Response.Redirect("~/Pages/Login/Login_Admin.aspx");
            }*/
            /* load a table of the current product */
            fillTable();
            productTable.Text += "</tbody>";
        }

        public void fillTable()
        {
            {
                try
                {
                    foreach (Product item in Product_Functions.getProduct())
                    {
                        productTable.Text += (product_functions.tableProducts(
                              item.productID
                            , item.Title
                            , item.Description
                            , item.Quantity
                            , item.Cost
                            , item.PicturePath));
                    }
                }
                catch (Exception ex)
                {
                    globalMethods.printDebug(
                        ("******ALERT*****\n" +
                        $"{ex}\n" +
                        "******ENDALERT*****\n"));
                }
            }
        }
    }
}
