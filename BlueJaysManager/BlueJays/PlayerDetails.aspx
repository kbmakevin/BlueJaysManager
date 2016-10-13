<%@ Page Title="Player Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PlayerDetails.aspx.cs" Inherits="BlueJaysManager.PlayerDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-offset-3 col-md-6">
                <h1>Player Details</h1>
                <h5>All Fields are required</h5>
                <br />
                <div class="form-group">
                    <label class="control-label" for="PlayerNumTextBox">Player Number</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="PlayerNumTextBox"
                        placeholder="23" required="true" TextMode="Number"></asp:TextBox>
                </div>

                 <div class="form-group">
                    <label class="control-label" for="NameTextBox">Name</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="NameTextBox"
                        placeholder="Name" required="true"></asp:TextBox>
                </div>

                 <div class="form-group">
                    <label class="control-label" for="PositionTextBox">Position</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="PositionTextBox"
                        placeholder="Position" required="true"></asp:TextBox>
                </div>

                 <div class="form-group">
                    <label class="control-label" for="HeightTextBox">Height (cm)</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="HeightTextBox"
                        placeholder="195" required="true" TextMode="Number"></asp:TextBox>
                </div>

                 <div class="form-group">
                    <label class="control-label" for="WeightTextBox">Weight (lbs)</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="WeightTextBox"
                        placeholder="221" required="true" TextMode="Number"></asp:TextBox>
                </div>

                 <div class="form-group">
                    <label class="control-label" for="DateOfBirthTextBox">Date of Birth</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="DateOfBirthTextBox"
                        placeholder="2016-09-28" required="true" TextMode="Date"></asp:TextBox>
                </div>

                 <div class="form-group">
                    <label class="control-label" for="SkillOrientationTextBox">Batting/Throwing Arms</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="SkillOrientationTextBox"
                        placeholder="R/R" required="true"></asp:TextBox>
                </div>

                <div class="text-right">
                    <asp:Button Text="Cancel" ID="CancelButton" CssClass="btn btn-warning btn-lg" runat="server" UseSubmitBehavior="false" CausesValidation="false" OnClick="CancelButton_Click" />
                    <asp:Button Text="Save" ID="SaveButton" CssClass="btn btn-primary btn-lg" runat="server" OnClick="SaveButton_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
