using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// using statements required for EF DB access
using BlueJaysManager.Models;
using System.Web.ModelBinding;

namespace BlueJaysManager
{
    public partial class PlayerDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Request.QueryString.Count > 0)
            {
                this.GetPlayer();

                // hide the playerNum textbox to prevent accidentally changing 
                // table record's key
                CreatePlayerPlaceHolder.Visible = false;
            }
        }

        private void GetPlayer()
        {
            // populate the form with existing data from db
            int PlayerID = Convert.ToInt32(Request.QueryString["PlayerNum"]);

            // connect to the EF DB
            using (BlueJaysContext db = new BlueJaysContext())
            {
                // populate a player object isntance with the PlayerID from the
                // URL parameter
                Player updatedPlayer = (from player in db.Players
                                        where player.PlayerNum == PlayerID
                                        select player).FirstOrDefault();

                // map the player properties to the form control
                if (updatedPlayer != null)
                {
                    PlayerNumTextBox.Text = updatedPlayer.PlayerNum.ToString();
                    NameTextBox.Text = updatedPlayer.Name;
                    PositionTextBox.Text = updatedPlayer.Position;
                    HeightTextBox.Text = updatedPlayer.Height.ToString();
                    WeightTextBox.Text = updatedPlayer.Weight.ToString();
                    DateOfBirthTextBox.Text = updatedPlayer.DateOfBirth.ToString("yyyy-MM-dd");
                    SkillOrientationTextBox.Text = updatedPlayer.SkillOrientation;
                }
            }
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            // Redirect back to the players page
            Response.Redirect("Players.aspx");
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            // Use EF to connect tothe server
            using (BlueJaysContext db = new BlueJaysContext())
            {
                // use the player model to create a new player object and 
                // save a new record
                Player newPlayer = new Player();

                int PlayerNum = 0;
                if (Request.QueryString.Count > 0) // our URL has a PlayerNum in it
                {
                    // get the num from the URL
                    PlayerNum = Convert.ToInt32(Request.QueryString["PlayerNum"]);

                    // get the current player from EF db
                    newPlayer = (from player in db.Players
                                 where player.PlayerNum == PlayerNum
                                 select player).FirstOrDefault();
                }

                // add form data to the new player record
                newPlayer.PlayerNum = Convert.ToInt32(PlayerNumTextBox.Text);
                newPlayer.Name = NameTextBox.Text;
                newPlayer.Position = PositionTextBox.Text;
                newPlayer.Height = Convert.ToInt32(HeightTextBox.Text);
                newPlayer.Weight = Convert.ToInt32(WeightTextBox.Text);
                newPlayer.DateOfBirth = Convert.ToDateTime(DateOfBirthTextBox.Text);
                newPlayer.SkillOrientation = SkillOrientationTextBox.Text;

                // use LINQ or ADO.NET to add / insert new player into db
                if (PlayerNum == 0)
                {
                    db.Players.Add(newPlayer);
                }

                // save our changes - also updates and inserts
                db.SaveChanges();

                // Redirect back to the updated players page
                Response.Redirect("Players.aspx");
            }
        }
    }
}