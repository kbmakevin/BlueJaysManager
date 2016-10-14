<%@ Page Title="Players" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Players.aspx.cs" Inherits="BlueJaysManager.Players" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-offset-1 col-md-10">

                <h1>Player Roster</h1>
                <a href="PlayerDetails.aspx" class="btn btn-success btn-sm">
                    <i class="fa fa-plus">Add Player</i>
                </a>

                <div>
                    <label for="PageSizeDropDownList">Records per Page:</label>
                    <asp:DropDownList ID="PageSizeDropDownList" runat="server"
                        AutoPostBack="true" CssClass="btn btn-default btn-sm dropdown-toggle"
                        OnSelectedIndexChanged="PageSizeDropDownList_SelectedIndexChanged">
                        <asp:ListItem Text="3" Value="3" />
                        <asp:ListItem Text="5" Value="5" />
                        <asp:ListItem Text="10" Value="10" />
                        <asp:ListItem Text="All" Value="10000" />
                    </asp:DropDownList>
                </div>

                <asp:GridView ID="PlayersGridView" runat="server" AutoGenerateColumns="false"
                    CssClass="table table-bordered table-striped table-hover"
                    DataKeyNames="PlayerNum"
                    OnRowDeleting="PlayersGridView_RowDeleting"
                    AllowPaging="true" PageSize="3"
                    AllowSorting="true"
                    OnSorting="PlayersGridView_Sorting"
                    OnRowDataBound="PlayersGridView_RowDataBound"
                    OnPageIndexChanging="PlayersGridView_PageIndexChanging"
                    PagerStyle-CssClass="pagination-ys">
                    <Columns>
                        <asp:BoundField DataField="PlayerNum" HeaderText="Player #" Visible="true" SortExpression="PlayerNum" />
                        <asp:BoundField DataField="Name" HeaderText="Name" Visible="true" SortExpression="Name" />
                        <asp:BoundField DataField="Position" HeaderText="Position" Visible="true" SortExpression="Position" />
                        <asp:BoundField DataField="Height" HeaderText="Height (cm)" Visible="true" SortExpression="Height" />
                        <asp:BoundField DataField="Weight" HeaderText="Weight (lbs)" Visible="true" SortExpression="Weight" />
                        <asp:BoundField DataField="DateOfBirth" HeaderText="Date of Birth" Visible="true"
                            DataFormatString="{0:MMM dd, yyyy}" SortExpression="DateOfBirth" />

                        <asp:HyperLinkField HeaderText="Edit" Text="<i class='fa fa-pencil-square-o fa-lg'></i> Edit" NavigateUrl="/BlueJays/PlayerDetails.aspx" ControlStyle-CssClass="btn btn-primary btn-sm" runat="server" DataNavigateUrlFields="PlayerNum"
                            DataNavigateUrlFormatString="PlayerDetails.aspx?PlayerNum={0}" />

                        <asp:CommandField HeaderText="Delete" DeleteText="<i class='fa fa-trash-o fa-lg'></i> Delete" ShowDeleteButton="true" ButtonType="Link" ControlStyle-CssClass="btn btn-danger btn-sm" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>


</asp:Content>
