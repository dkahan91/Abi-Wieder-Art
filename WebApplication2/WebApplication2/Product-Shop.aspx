<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Product-Shop.aspx.cs" Inherits="WebApplication2.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Shop</h1>
   <div id="searchbar">
       <asp:TextBox ID="TextBox1" runat="server" Height="25px" OnTextChanged="TextBox1_TextChanged" Width="181px" placeholder="Search for a product..."></asp:TextBox>
   </div>
    <div>
       <p>Order by:</p>
       <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
           <asp:ListItem Value="1">Alphabetical</asp:ListItem>
           <asp:ListItem Value="2">Order by price</asp:ListItem>
       </asp:DropDownList>
    </div>

    
        <div id="query" runat="server"></div>
        <div>
        </div>
    </asp:Content>