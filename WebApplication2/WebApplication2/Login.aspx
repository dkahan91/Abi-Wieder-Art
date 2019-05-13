<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master"  AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication2.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2"  ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Login</h1>
  <p>Please enter your credentials in the boxes below</p>

  <p>Username:</p><asp:TextBox ID="uname" runat="server"></asp:TextBox>
  <p>Password:</p><asp:TextBox ID="pword" runat="server"></asp:TextBox>
        
  <div runat="server" id="test"></div>
  
  <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
  
  <p id="details" runat="server"></p>
  
        <h1>Register</h1>
  <p>Please create your registration below</p>

    <p>First Name:</p><asp:TextBox ID="f_name" runat="server"></asp:TextBox>
    <p>Last Name:</p><asp:TextBox ID="l_name" runat="server"></asp:TextBox>
  <p>Username:</p><asp:TextBox ID="new_user" runat="server"></asp:TextBox>
      <p>Email:</p>
    <asp:TextBox ID="new_email" runat="server"></asp:TextBox>
  <p>Password:</p><asp:TextBox ID="new_pw" runat="server"></asp:TextBox>
        
    <div runat="server" id="test1"></div>
      <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click1" />

  
 
  
  <p id="details2" runat="server"></p>
    </asp:Content>

