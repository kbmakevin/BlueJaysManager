<%@ Page Title="Players" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Players.aspx.cs" Inherits="BlueJaysManager.Players" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-offset-2 col-md-8">
                <asp:GridView ID="PlayersGridView" runat="server" AutoGenerateColumns="false"
                    CssClass="table table-bordered table-striped table-hover">
                    <Columns>
                        <asp:BoundField DataField="PlayerNum" HeaderText="Player #" Visible="true" />
                        <asp:BoundField DataField="Name" HeaderText="Name" Visible="true" />
                        <asp:BoundField DataField="Position" HeaderText="Position" Visible="true" />
                        <asp:BoundField DataField="Height" HeaderText="Height (cm)" Visible="true" />
                        <asp:BoundField DataField="Weight" HeaderText="Weight (lbs)" Visible="true" />
                        <asp:BoundField DataField="DateOfBirth" HeaderText="Date of Birth" Visible="true"
                            DataFormatString="{0:MMM dd, yyyy}" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>


</asp:Content>
