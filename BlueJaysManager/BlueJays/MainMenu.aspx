<%@ Page Title="Main Menu" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MainMenu.aspx.cs" Inherits="BlueJaysManager.BlueJays.MainMenu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">

        <div class="row">
            <div class="col-md-offset-3 col-md-6">
                <h1>Main Menu</h1>
                <div class="well">
                    <h3><i class="fa fa-leanpub fa-lg"></i>Players</h3>
                    <div class="list-group">
                        <a class="list-group-item" href="/BlueJays/Players.aspx"><i class="fa fa-th-list"></i>Player Roster</a>
                        <a class="list-group-item" href="/BlueJays/PlayerDetails.aspx"><i class="fa fa-plus-circle"></i>Add Players</a>
                    </div>
                </div>

                <div class="well">
                    <h3><i class="fa fa-book fa-lg"></i>Coaches</h3>
                    <div class="list-group">
                        <a class="list-group-item" href="/BlueJays/Coaches.aspx"><i class="fa fa-th-list"></i>Coach Roster</a>
                        <a class="list-group-item" href="/BlueJays/CoachDetails.aspx"><i class="fa fa-plus-circle"></i>Add Coaches</a>
                    </div>
                </div>

            </div>
        </div>
    </div>
</asp:Content>
