<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master"  AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication2.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2"  ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


<nav >
<p style="text-align:right;"><a href="login.html">Login</a></p>
<ul style="list-style:none;text-align:center;font-size:300%;">
  <li style="display:inline;"><a href="shop.html">Home</a></li>
  <li style="display:inline;"><a href="shop.html">Shop</a></li>
  <li style="display:inline;"><a href="shop.html">Comission</a></li>
  <li style="display:inline;"><a href="shop.html">Contact</a></li>
</ul>
</nav>
<div style="margin-left:40px;">
  <p>Please enter your credentials in the boxes below</p>
<p>Username:</p><asp:TextBox ID="uname" runat="server"></asp:TextBox>
  <p>Password:</p><asp:TextBox ID="pword" runat="server"></asp:TextBox>
  <!--<input type="submit" title="Submit" value="submit">-->
    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
  <p id="details" runat="server"></p>
    </div>
    </asp:Content>

