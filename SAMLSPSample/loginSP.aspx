﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginSP.aspx.cs" Inherits="SAMLSPSample.loginSP" %>

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
.pbutton {
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

<h2>Sample SP Provider Page</h2>

<form action="#" runat="server">
  
  <div class="container">
      
      <asp:Button  class="pbutton" ID="ssoLinkButton" runat="server" Text="Initiate SAML (SSO) Login Request" OnClick="ssoLinkButton_Click" />

  </div>

</form>


</body>
</html>