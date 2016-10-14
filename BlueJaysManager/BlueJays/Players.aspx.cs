using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// using statements that are required to connect to EF DB
using BlueJaysManager.Models;
using System.Web.ModelBinding;
using System.Linq.Dynamic;

namespace BlueJaysManager
{
    public partial class Players : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // if loading the page for the first time, populate with player roster grid
            if (!IsPostBack)
            {
                Session["SortColumn"] = "PlayerNum"; // default sort column
                Session["SortDirection"] = "ASC";

                // Get the player roster data
                this.GetPlayerRoster();
            }
        }

        /// <summary>
        /// This method gets the player data from the DB
        /// </summary>
        private void GetPlayerRoster()
        {
            // connect to EF DB
            using (BlueJaysContext db = new BlueJaysContext())
            {
                string SortString = Session["SortColumn"].ToString() + " " + Session["SortDirection"].ToString();

                // query the PlayerRoster Table using EF and LINQ
                var Players = (from allPlayers in db.Players
                               select allPlayers);

                // bind the result to the Players GridView
                PlayersGridView.DataSource = Players.AsQueryable().OrderBy(SortString).ToList();
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

        protected void PageSizeDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // set the new Page size
            PlayersGridView.PageSize = Convert.ToInt32(PageSizeDropDownList.SelectedValue);

            // refresh the Gridview
            this.GetPlayerRoster();
        }

        protected void PlayersGridView_Sorting(object sender, GridViewSortEventArgs e)
        {
            // get the column to sort by
            Session["SortColumn"] = e.SortExpression;

            // refresh the Gridview
            this.GetPlayerRoster();

            // toggle the direction
            Session["SortDirection"] = Session["SortDirection"].ToString() == "ASC" ? "DESC" : "ASC";
        }

        protected void PlayersGridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (IsPostBack)
            {
                if (e.Row.RowType == DataControlRowType.Header) // if header row has been clicked
                {
                    LinkButton linkbutton = new LinkButton();

                    for (int index = 0; index < PlayersGridView.Columns.Count - 1; index++)
                    {
                        if (PlayersGridView.Columns[index].SortExpression == Session["SortColumn"].ToString())
                        {
                            if (Session["SortDirection"].ToString() == "ASC")
                            {
                                linkbutton.Text = " <i class='fa fa-caret-up fa-lg'></i>";
                            }
                            else
                            {
                                linkbutton.Text = " <i class='fa fa-caret-down fa-lg'></i>";
                            }

                            e.Row.Cells[index].Controls.Add(linkbutton);
                        }
                    }
                }
            }
        }

        protected void PlayersGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            // Set the new page number
            PlayersGridView.PageIndex = e.NewPageIndex;

            // refresh the Gridview
            this.GetPlayerRoster();
        }
    }
}