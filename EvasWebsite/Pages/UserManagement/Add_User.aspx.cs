﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EvasWebsite.Data;

namespace EvasWebsite.Pages.UserManagement
{
    public partial class Add_User : System.Web.UI.Page
    {
        Record_User user = new Record_User();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SecurityLevel"] != "0")
            {
                Response.Redirect("~/Pages/Login/Login_Admin.aspx");
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            /* very simple method to call the add to database method */
            try
            {
                collectData();
                if (Functions_User.AddUser(
                      user.userName
                    , user.Password
                    , user.securityLevel))
                {
                    lblError.Text = "Add Complete.";
                    System.Diagnostics.Debug.WriteLine("\n*******ALERT******\n" +
                                                       $"{user.userName}\n" +
                                                       $"{user.Password}\n" +
                                                       $"{user.securityLevel}");
                }
            }
            catch(Exception ex)
            {
                lblError.Text = "Add Failed.";
                System.Diagnostics.Debug.WriteLine("\nAdd_User error: \n" + ex + "\n");
            }
        }

        /*collec the data */
        public void collectData()
        {
            user.userName = txtUserName.Text;
            user.Password = user.encryptPassword(txtPassword.Text);
            user.securityLevel = Convert.ToInt32(txtSecurityLevel.Text);
        }
    }
}