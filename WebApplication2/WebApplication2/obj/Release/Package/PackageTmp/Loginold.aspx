<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Loginold.aspx.cs" Inherits="WebApplication2.Loginold" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"><nav >
<p style="text-align:right;"><a href="login.html">Login</a></p>
<ul style="list-style:none;text-align:center;font-size:300%;">
  <li style="display:inline;"><a href="shop.html">Home</a></li>
  <li style="display:inline;"><a href="shop.html">Shop</a></li>
  <li style="display:inline;"><a href="shop.html">Comission</a></li>
  <li style="display:inline;"><a href="shop.html">Contact</a></li>
</ul>
</nav>
    <style type="text/css">
        #Button1 {
            height: 35px;
            width: 82px;
        }
    </style>
    <style type="text/css">
        #Text1 {}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <form id="form1" runat="server">
    <div style="margin-left:40px;">
    <p>Please enter your username</p>
    <input id="Text1" type="text" runat="server" />
    <p id ="ttt" runat="server">Please enter your password</p>
    <input id="Password1" type="password" runat="server" /><br />
       &nbsp;<asp:Label ID="tester" runat="server" Text="Label">Test</asp:Label>
       <input id="Button1" type="button" value="button" runat="server"/>
       </div>
           </form>
</asp:Content>
