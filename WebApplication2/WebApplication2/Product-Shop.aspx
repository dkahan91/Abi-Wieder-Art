<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Product-Shop.aspx.cs" Inherits="WebApplication2.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <h1>Shop</h1>
   <div id="searchbar">
       <asp:TextBox ID="TextBox1" runat="server" Height="25px" OnTextChanged="TextBox1_TextChanged" Width="181px" placeholder="Search for a product..."></asp:TextBox>
    </div>
        <div id="query" runat="server"></div>
        <div>
        </div>
    </asp:Content>