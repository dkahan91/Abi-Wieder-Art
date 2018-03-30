<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormtestlogin.aspx.cs" Inherits="WebApplication2.WebFormtestlogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

            <div style="margin-left:40px;">
  <p>Please enter your credentials in the boxes below</p>
<p>Username:</p><asp:TextBox ID="uname" runat="server" OnTextChanged="uname_TextChanged"></asp:TextBox>
  <p>Password:</p><asp:TextBox ID="pword" runat="server"></asp:TextBox>
  <!--<input type="submit" title="Submit" value="submit">-->
<asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
  <p id="details" runat="server"></p>

        </div>
    </form>
</body>
</html>
