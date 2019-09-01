//Add_Item Code Behind
//Programmed by: Markus Reynolds
//09/01/2019

using System;
using EvasWebsite.Data;
using System.Data.SqlClient;

namespace EvasWebsite.Pages
{
    public partial class Add_Item : System.Web.UI.Page
    {
        /* I think the only problem is that we are storing data here
         * we should probably move this to the data layer, or call product 
         */

        public string Title { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public float Cost { get; set; }
        public string PicturePath { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            /*
             * Security, prevent people from coming on here that don't belong
             */
            /* 
               if (Session["SecurityLevel"] != "A")
                    {
                        Response.Redirect("Login_Admin.aspx");
                    } 
            */
        }

        protected void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                captureData();
                lblTitlePre.Text = Title;
                lblDescriptionPre.Text = Description;
                lblQuantityPre.Text = Quantity.ToString();
                lblCostPre.Text = Cost.ToString();
                imgPicturePreview.ImageUrl = PicturePath;
            }
            catch(Exception ex)
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
                if (Data_Layer.AddProduct
                    (Title
                    , Description
                    , Quantity
                    , Cost
                    , PicturePath))
                {
                    lblError.Text = "Upload Successful";
                }
                else
                {
                    lblError.Text = "Upload Failed";
                }
            }
            catch(Exception ex)
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
                Title = txtTitle.Text;
                Description = txtDescription.Text;
                Quantity = Convert.ToInt32(txtQuantity.Text);
                Cost = Convert.ToSingle(txtQuantity.Text);
                if (upPicture.HasFile)
                {
                    PicturePath = "~/Pictures/" + upPicture.FileName;
                    upPicture.SaveAs(Server.MapPath(PicturePath));
                }
                else
                {
                    lblError.Text = "Please select a file to upload";
                }

                System.Diagnostics.Debug.WriteLine($"\nAddTest: {Title} \n{Description} \n{Quantity} \n{Cost} \n{PicturePath} \n");
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error Occured in captureData(): " + ex.ToString() +"\n");
            }
        }
    }
}
