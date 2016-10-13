﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// required for Identity and OWIN Security
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

namespace BlueJaysManager
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // store session info and authentication methods in the authentication manager object
            var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;

            // perform signout
            authenticationManager.SignOut();

            // Redirect the user to the Login Page
            Response.Redirect("Login.aspx");
        }
    }
}