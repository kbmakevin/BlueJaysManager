using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// using statements that are required to connect to EF DB
using BlueJaysManager.Models;
using System.Web.ModelBinding;

namespace BlueJaysManager
{
    public partial class Players : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // if loading the page for the first time, populate with player roster grid
            if (!IsPostBack)
            {
                // Get the player roster data
                this.GetPlayerRoster();
            }
        }

        /// <summary>
        /// This method gets the player data from the DB
        /// </summary>
        private void GetPlayerRoster()
        {
            // connect to EF
            using (BlueJaysContext db = new BlueJaysContext())
            {
                // query the PlayerRoster Table using EF and LINQ
                var Players = (from allPlayers in db.Players
                               select allPlayers);

                // bind the result to the Players GridView
                PlayersGridView.DataSource = Players.ToList();
                PlayersGridView.DataBind();
            }
        }
    }
}