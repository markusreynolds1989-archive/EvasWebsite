using System;

namespace EvasWebsite.Pages
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void test_Click(object sender, EventArgs e)
        {
            label.Text = "BLAH";
        }
    }
}