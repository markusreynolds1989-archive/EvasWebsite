using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EvasWebsite.Data;

namespace EvasWebsite.Pages
{
    public partial class Login_Admin : System.Web.UI.Page
    {
        Users currentUser = new Users();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AdminLogin_Authenticate(object sender, AuthenticateEventArgs e)
        {
            try
            {
                currentUser.securityLevel = Data_Layer.verifyUser(AdminLogin.UserName,currentUser.encryptPassword(AdminLogin.Password));
                System.Diagnostics.Debug.WriteLine(currentUser.securityLevel);

                switch (currentUser.securityLevel)
                {
                    case 0:
                        e.Authenticated = true;
                        Session["SecurityLevel"] = "0";
                        break;

                    case 1:

                        e.Authenticated = true;
                        Session["SecurityLevel"] = "1";
                        break;

                    case 2:
                        e.Authenticated = true;
                        Session["SecurityLevel"] = "2";
                        break;

                    case 3:
                        e.Authenticated = true;
                        Session["SecuirtyLevel"] = "3";
                        break;

                    default:
                        e.Authenticated = false;
                        break;
                }
                
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Verify Error: \n" + ex + "\n");
            }
        }
    }
}