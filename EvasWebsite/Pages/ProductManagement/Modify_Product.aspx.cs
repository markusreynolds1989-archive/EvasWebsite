using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using EvasWebsite;
using EvasWebsite.Data;

namespace EvasWebsite.Pages.ProductManagement
{
    public partial class Modify_Product : System.Web.UI.Page
    {
        Record_Product product = new Record_Product();
        Functions_Product functions_product = new Functions_Product();

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
                        productTable.Text += (functions_product.tableProducts(
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
            captureData();
            try
            {
                if (Functions_Product.modifyProduct(product.productID,
                                                product.Title,
                                                product.Description,
                                                product.Quantity,
                                                product.Cost,
                                                product.PicturePath))
                {

                }
            }
            catch (Exception ex)
            {
                globalMethods.printDebug(ex.ToString());
            }
            txtID.Text = null;
        }
        public void captureData()
        {
            product.productID = Convert.ToInt32(txtID.Text);
            product.Title = txtTitle.Text;
            product.Description = txtDesc.Text;
            product.Quantity = Convert.ToInt32(txtQuan.Text);
            product.Cost = Convert.ToSingle(txtCost.Text);
            product.PicturePath = upPicture.FileName;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

        }

        protected void txtID_TextChanged(object sender, EventArgs e)
        {
            /*get data for the rest of the boxes to fill in */
        }
    }
}
