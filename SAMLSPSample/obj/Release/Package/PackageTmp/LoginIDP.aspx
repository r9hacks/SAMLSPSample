<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginIDP.aspx.cs" Inherits="WebApplication3.LoginIDP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="loginForm" runat="server" defaultbutton="loginButton" defaultfocus="passwordTextBox">
    <div>
		<h1>Login to the Identity Provider</h1>
		<table border="0">
			<tr>
				<td>
					<p>User name:</p>
				</td>
				<td>
					<asp:TextBox ID="userNameTextBox" runat="server">idp-user</asp:TextBox>
				</td>
			</tr>
			<tr>
				<td>
					<p>Password:</p>
				</td>
				<td>
					<asp:TextBox ID="passwordTextBox" runat="server" TextMode="Password"></asp:TextBox>
				</td>
			</tr>
			<tr>
				<td colspan="2">
					<asp:Button ID="loginButton" runat="server" Text="Login" OnClick="loginButton_Click" />
				</td>
			</tr>
		</table>
		<p>
			<asp:Label ID="errorMessageLabel" runat="server" ForeColor="Red"></asp:Label>
		</p>    
    </div>
    </form>
</body>
</html>
