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
                imgPicturePreview.ImageUrl = path;
                imgPicturePreview.Visible = true;
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
            /* save all the information to linq object 
             * this info needs to get posted to the other page
             * down the line this will be sql but 
             * from what I've seen it's better to have this as
             * iterable linq first 
             */
            string connect =           "user id = username; " +
                                       "password=password;server=serverurl;" +
                                       "Trusted_Connection=yes;" +
                                       "database=C:\\Users\\Reynolds\\source\\repos\\EvasWebsite" +
                                       "\\EvasWebsite\\App_Data\\ECommerce.mdf; " +
                                       "connection timeout=30";
            var product = new Product();
            string sqlCmd = "insert into tblProducts(Title, Description, Quantity, Cost, PicturePath, Updt_dt_tm)" +
            $"values('{txtTitle.Text}', '{txtDescription.Text}', {txtQuantity.Text}, {txtCost.Text}, '{upPicture.FileName}', SYSDATETIME());";
            var myConnection = new SqlConnection(connect);
            var command = new SqlCommand(sqlCmd,myConnection);
            myConnection.Open();
            command.ExecuteNonQuery();
            myConnection.Close();
        }
    }
}
