<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Welcome to the Service Provider Site</h1>
        <p class="lead">You are logged in as <%= Context.User.Identity.Name %>.</p>
        
        <div id="attributesDiv" runat="server" visible="false">
            <h2>User Attributes</h2>
            <asp:repeater id="attributesRepeater" runat="server">
	            <ItemTemplate>
		            <p><%# DataBinder.Eval(Container.DataItem, "AttributeName") %>: <%# DataBinder.Eval(Container.DataItem, "AttributeValue") %></p>
	            </ItemTemplate>
            </asp:repeater>
        </div>

        

        <p>
        <asp:Button ID="logoutButton" runat="server" Text="Logout" OnClick="logoutButton_Click" class="btn btn-primary btn-lg"/>

        </p>
    </div>

</asp:Content>


    
