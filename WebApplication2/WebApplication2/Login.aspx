<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master"  AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication2.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2"  ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-left:40px;">
  <p>Please enter your credentials in the boxes below</p>

  <p>Username:</p><asp:TextBox ID="uname" runat="server"></asp:TextBox>
  <p>Password:</p><asp:TextBox ID="pword" runat="server"></asp:TextBox>

  <div runat="server" id="test"></div>
  
  <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
  
  <p id="details" runat="server"></p>
    
    </asp:Content>

