﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace S3L2
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["Username"] != null)
            {
                string username = Request.Cookies["Username"].Value;
                lblUsername.Text = "Benvenuto, " + username;
            }
            else
            {
                Response.Redirect("Login.aspx");
            }

        }
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            
            Response.Cookies["Username"].Expires = DateTime.Now.AddDays(-1);

            Response.Redirect("Login.aspx");
        }
    }
}