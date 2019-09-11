//Add_Item Code Behind
//Programmed by: Markus Reynolds
//09/01/2019

using EvasWebsite.Data;
using System;

namespace EvasWebsite.Pages
{
    public partial class Add_Item : System.Web.UI.Page
    {
        /* new object of the Product class in the app_data 
         * Use it here to keep OOP going correctly
         */
        Product product = new Product();

        protected void Page_Load(object sender, EventArgs e)
        {
            /*
             * Security, prevent people from coming on here that don't belong
             */
            
               if (Session["SecurityLevel"] != "0")
                    {
                        Response.Redirect("~/Pages/Login/Login_Admin.aspx");
                    }
            lblError.Visible = false;
        }

        protected void btnPreview_Click(object sender, EventArgs e) /*kill this and make it client side */
        {
            try
            {
                captureData();
                lblTitlePre.Text = product.Title;
                lblDescriptionPre.Text = product.Description;
                lblQuantityPre.Text = product.Quantity.ToString();
                lblCostPre.Text = product.Cost.ToString();
                imgPicturePreview.ImageUrl = product.PicturePath;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error Occured in Preview: \n" + ex.ToString() + "\n");
            }
        }

        /*Run the Add_Product Method from the Data_layer */
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                captureData();
                if (Product_Functions.AddProduct
                    (product.Title
                    , product.Description
                    , product.Quantity
                    , product.Cost
                    , product.PicturePath))
                {
                    lblError.Visible = true;
                    lblError.Text = "Upload Successful!";
                }
                else
                {
                    lblError.Visible = true;
                    lblError.Text = "Upload Failed!";
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error Occured in Add: \n" + ex.ToString() + "\n");
            }
        }


        public void captureData()
        {
            /* Js validation should take care of most of the heavy
             * lifting for us, but the try is there nonetheless
             * This method appears to be perfect
             */
            try
            {
                product.Title = txtTitle.Text;
                product.Description = txtDescription.Text;
                product.Quantity = Convert.ToInt32(txtQuantity.Text);
                product.Cost = Convert.ToDouble(txtCost.Text);

                if (upPicture.HasFile) /*save this item between collections */
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

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
            txtDescription.Text = "";
            txtQuantity.Text = "";
            txtCost.Text = "";
        }
    }
}
