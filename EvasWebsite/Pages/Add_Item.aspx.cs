using System;

namespace EvasWebsite.Pages
{
    public partial class Add_Item : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            /* Add in funcitonality
             * When the user clicks this button it verifies the picture
             * and then moves it to the pictures folder and then that url to the database
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
                    else
                    {
                        return "";
                    }
                }
                path = "C:\\Users\\Reynolds\\source\\repos\\EvasWebsite\\EvasWebsite\\Pictures\\" + getFileName();
                lblError.Text = path;
            }
            catch (NullReferenceException)
            {
                lblError.Text = "Input File";
            }
        }
    }
}
