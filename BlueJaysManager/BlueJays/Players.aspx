<%@ Page Title="Players" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Players.aspx.cs" Inherits="BlueJaysManager.Players" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-offset-1 col-md-10">

                <h1>Player Roster</h1>
                <a href="PlayerDetails.aspx" class="btn btn-success btn-sm">
                    <i class="fa fa-plus"> Add Player</i>
                </a>
                <asp:GridView ID="PlayersGridView" runat="server" AutoGenerateColumns="false"
                    CssClass="table table-bordered table-striped table-hover"
                    DataKeyNames="PlayerNum"
                    OnRowDeleting="PlayersGridView_RowDeleting">
                    <Columns>
                        <asp:BoundField DataField="PlayerNum" HeaderText="Player #" Visible="true" />
                        <asp:BoundField DataField="Name" HeaderText="Name" Visible="true" />
                        <asp:BoundField DataField="Position" HeaderText="Position" Visible="true" />
                        <asp:BoundField DataField="Height" HeaderText="Height (cm)" Visible="true" />
                        <asp:BoundField DataField="Weight" HeaderText="Weight (lbs)" Visible="true" />
                        <asp:BoundField DataField="DateOfBirth" HeaderText="Date of Birth" Visible="true"
                            DataFormatString="{0:MMM dd, yyyy}" />

                        <asp:HyperLinkField HeaderText="Edit" Text="<i class='fa fa-pencil-square-o fa-lg'></i> Edit" NavigateUrl="/BlueJays/PlayerDetails.aspx" ControlStyle-CssClass="btn btn-primary btn-sm" runat="server" DataNavigateUrlFields="PlayerNum"
                            DataNavigateUrlFormatString="PlayerDetails.aspx?PlayerNum={0}" />

                        <asp:CommandField HeaderText="Delete" DeleteText="<i class='fa fa-trash-o fa-lg'></i> Delete" ShowDeleteButton="true" ButtonType="Link" ControlStyle-CssClass="btn btn-danger btn-sm" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>


</asp:Content>
