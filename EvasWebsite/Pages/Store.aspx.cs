﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EvasWebsite.Data;

namespace EvasWebsite.Pages
{
    public partial class Store : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*potential way to load in the dynamic html
             */

            var product = new Product();
            html.DocumentContent = product.displayProduct();
        }
    }
}