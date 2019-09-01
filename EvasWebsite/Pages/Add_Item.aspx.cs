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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPreview_Click(object sender, EventArgs e)
        {
            /* Add in funcitonality
             * When the user clicks this button it verifies the picture
             * and then moves it to the pictures folder and then that url to the database
             * scratch that, we want the saving to be done in the next method
             */
            string fileName;
            string path;
            try
            {
                string getFileName()
                {
                    if (upPicture.HasFile == true)
                    {
                        fileName = upPicture.FileName;
                        return fileName;
                    }
                    return null;
                }
                /* Change the path name when we go to the server */
                /* TODO: Clean up this ugly mess */
                path = "C:\\Users\\Reynolds\\source\\repos\\EvasWebsite\\EvasWebsite\\Pictures\\" + getFileName();
                lblError.Text = path;
                upPicture.SaveAs(path);
                lblTitlePre.Text = txtTitle.Text;
                lblDescriptionPre.Text = txtDescription.Text;
                lblQuantityPre.Text = txtQuantity.Text;
                lblCostPre.Text = txtCost.Text;

            }
            catch (NullReferenceException)
            {
                lblError.Text = "Please input a file.";
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            /*capture data*/

            string title = txtTitle.Text;
            string desc = txtDescription.Text;
            int quant = Convert.ToInt32(txtQuantity.Text);
            float cost = Convert.ToSingle(txtCost.Text);
            string picture = upPicture.FileName;
            
            /*save it to the database */

            if (Data_Layer.AddProduct(title
                , desc
                , quant
                , cost
                , picture))
            {
                lblError.Text = "Did it work!?";
            }
            else
            {
                lblError.Text = "Didn't work.";
            }
        }
    }
}
