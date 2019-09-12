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
        Record_Product product = new Record_Product();
        Functions_Product product_functions = new Functions_Product();

        protected void Page_Load(object sender, EventArgs e)
        {
            
            /*if (Session["SecurityLevel"] != "0")
            {
                Response.Redirect("~/Pages/Login/Login_Admin.aspx");
            }*/
            /* load a table of the current product */
            fillTable();
        }

        /* this function combines the product list with the HTML to turn it into a table */
        public void fillTable()
        {
            {
                productTable.Text = @"
            <div class = 'container'>
                <thead>
                    <tr>
                        <th scope = 'col'>ID</th>
                        <th scope = 'col'>Title</th>
                        <th scope = 'col'>Description</th>
                        <th scope = 'col'>Quantity</th>
                        <th scope = 'col'>Cost</th>
                        <th scope = 'col'>Picture Path</th>
                    </tr>
                </thead>
                <tbody>";
                try
                {
                    foreach (Record_Product item in Functions_Product.getProduct())
                    {
                        productTable.Text += (product_functions.tableProducts(
                              item.productID
                            , item.Title
                            , item.Description
                            , item.Quantity
                            , item.Cost
                            , item.PicturePath));
                    }
                    productTable.Text += "</tbody></div>";
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

        protected void btnModify_Click(object sender, EventArgs e)
        {
            txtID.Text = null;
            
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

        }
        /*
        public void captureData()
        {
            /* Js validation should take care of most of the heavy
             * lifting for us, but the try is there nonetheless
             * This method appears to be perfect

            try
            {
                product.Title = ;
                product.Description = txtDescription.Text;
                product.Quantity = Convert.ToInt32(txtQuantity.Text);
                product.Cost = Convert.ToDouble(txtCost.Text);

                if (upPicture.HasFile) /*save this item between collections 
                {
                    product.PicturePath = "/Pictures/" + upPicture.FileName;
                    upPicture.SaveAs(Server.MapPath(product.PicturePath));
                }
                else
                {
                    lblError.Visible = true;
                    lblError.Text = "Please select a file to upload";
                }

                System.Diagnostics.Debug.WriteLine($"\nAddTest: {product.Title} \n{product.Description} \n{product.Quantity} \n{product.Cost} \n{product.PicturePath} \n");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error Occured in captureData(): " + ex.ToString() + "\n");
            }
        }
    */
    }
}
