using System;
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
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // check if a user is logged in
                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    // show the bluejays content area
                    BlueJaysPlaceHolder.Visible = true;
                    PublicPlaceHolder.Visible = false;
                }
                else
                {
                    // only show the login and register links in nav
                    BlueJaysPlaceHolder.Visible = false;
                    PublicPlaceHolder.Visible = true;
                }
            }

            SetActivePages();
        }

        private void SetActivePages()
        {
            switch (Page.Title)
            {
                case "Home":
                    home.Attributes.Add("class", "active");
                    break;
                case "Players":
                    players.Attributes.Add("class", "active");
                    break;
                case "Coaches":
                    coaches.Attributes.Add("class", "active");
                    break;
                case "About":
                    about.Attributes.Add("class", "active");
                    break;
                case "Contact":
                    contact.Attributes.Add("class", "active");
                    break;
                case "Main Menu":
                    menu.Attributes.Add("class", "active");
                    break;
                case "Register":
                    register.Attributes.Add("class", "active");
                    break;
                case "Login":
                    login.Attributes.Add("class", "active");
                    break;
            }
        }
    }
}