<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginSP.aspx.cs" Inherits="WebApplication3.loginSP" %>

<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1 id="HeaderH1" runat="server">Hello World</h1>
    <form id="loginForm" runat="server">
    <div>

        <h1>SP Sample</h1>
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
					<asp:Button ID="loginButton" runat="server" Text="Login" />
				</td>
                <td colspan="2">
					<asp:Button ID="ssoLinkButton" runat="server" Text="Login With PACI" OnClick="ssoLinkButton_Click" />
				</td>
			</tr>
		</table>
		<p>
			<asp:Label ID="errorMessageLabel" runat="server" ForeColor="Red"></asp:Label>
		</p>    

    </div>
    </form>

</body>
</html>--%>

<!DOCTYPE html>
<html>
<head>
<meta name="viewport" content="width=device-width, initial-scale=1">
<style>
body {font-family: Arial, Helvetica, sans-serif;}
form {border: 3px solid #f1f1f1;}

input[type=text], input[type=password] {
    width: 100%;
    padding: 12px 20px;
    margin: 8px 0;
    display: inline-block;
    border: 1px solid #ccc;
    box-sizing: border-box;
}

button {
    background-color: #4CAF50;
    color: white;
    padding: 14px 20px;
    margin: 8px 0;
    border: none;
    cursor: pointer;
    width: 100%;
}
.pacibutton {
    background-color: #1644ea;
    color: white;
    padding: 14px 20px;
    margin: 8px 0;
    border: none;
    cursor: pointer;
    width: 100%;
}

button:hover {
    opacity: 0.8;
}

.cancelbtn {
    width: auto;
    padding: 10px 18px;
    background-color: #f44336;
}

.imgcontainer {
    text-align: center;
    /*margin: 24px 0 12px 0;*/
}

img.avatar {
    width: 50px;
   // border-radius: 50%;
}

.container {
    padding: 16px;
}

span.psw {
    float: right;
    padding-top: 16px;
}

/* Change styles for span and cancel button on extra small screens */
@media screen and (max-width: 300px) {
    span.psw {
       display: block;
       float: none;
    }
    .cancelbtn {
       width: 100%;
    }
}
.main-center{
 	margin-top: 30px;
 	margin: 0 auto;
 	max-width: 600px;
    padding: 40px 40px;

}
</style>
</head>
<body  class = "main-center">
<%--        <div class="imgcontainer">
    <%--<img src="https://www.sharpersoftware.com/img/Customers/PACILogo.jpg" alt="Avatar" class="avatar">
    <img src="https://exgisapps.paci.gov.kw/PACILocations/images/paci.png" alt="Avatar" class="avatar">
      
  </div>--%>
<h2>Sample SP login form</h2>

<form action="#" runat="server">
  

  <div class="container">
    <label for="uname"><b>Username</b></label>
    <input type="text" placeholder="Enter Username" name="uname" >

    <label for="psw"><b>Password</b></label>
    <input type="password" placeholder="Enter Password" name="psw" >
        
    
      <button type="submit">Login</button>
      
      <asp:Button  class="pacibutton" ID="ssoLinkButton" runat="server" Text="Login With PACI" OnClick="ssoLinkButton_Click" />
         
    <label>
      <input type="checkbox" checked="checked" name="remember"> Remember me
    </label>
  </div>

  <div class="container" style="background-color:#f1f1f1">
    <button type="button" class="cancelbtn">Cancel</button>
    <span class="psw">Forgot <a href="#">password?</a></span>
  </div>
</form>


</body>
</html>