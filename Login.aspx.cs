﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace S3L2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();

            if (!string.IsNullOrEmpty(username))
            {
                Response.Cookies["Username"].Value = username;
                Response.Cookies["Username"].Expires = DateTime.Now.AddDays(1);
                Response.Redirect("Home.aspx");
            }
        }
    }
}