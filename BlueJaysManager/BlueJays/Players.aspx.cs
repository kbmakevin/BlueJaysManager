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

        protected void PlayersGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // store which row was clicked
            int selectedRow = e.RowIndex;

            // get the selected PlayerNum using the Grid's DataKey collection
            int PlayerNum = Convert.ToInt32(PlayersGridView.DataKeys[selectedRow].Values["PlayerNum"]);

            // use EF and LINQ to find the selected student in the DB and remove it
            using (BlueJaysContext db = new BlueJaysContext())
            {
                // create object of the Player class and store the query inside of it
                Player deletedPlayer = (from playerRecords in db.Players
                                        where playerRecords.PlayerNum == PlayerNum
                                        select playerRecords).FirstOrDefault();

                // remove the selected student from the db
                db.Players.Remove(deletedPlayer);

                // save my changes back to the db
                db.SaveChanges();

                // refresh the grid
                this.GetPlayerRoster();
            }
        }
    }
}