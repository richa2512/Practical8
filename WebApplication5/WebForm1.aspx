<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication5.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    Home page
</asp:Content>
<asp:Content ID="Content2" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
    <asp:Button ID="btnHeader" runat="server" onclick="btnHeader_Click" 
    Text="Change Header" />
<asp:TextBox ID="txtHeader" runat="server"></asp:TextBox>
</asp:Content>

