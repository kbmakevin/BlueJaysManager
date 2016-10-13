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

        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            // Redirect back to the players page
            Response.Redirect("BlueJays/Players.aspx");
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
                if (Request.QueryString.Count > 0) // our URL has a PlayerID in it
                {
                    // get the id from the URL
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
                Response.Redirect("BlueJays/Players.aspx");
            }
        }
    }
}