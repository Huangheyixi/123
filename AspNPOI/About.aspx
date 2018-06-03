<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="AspNPOI.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    <asp:Repeater ID="Repeater1" runat="server">
    <ItemTemplate>
        <div class="movies">
            <h1><%#Eval("Name") %></h1>
        </div>
        <b>Directed by:</b><%#Eval("Name") %>
        <br />
        <b>Description:</b><%#Eval("Name") %>
    </ItemTemplate>
</asp:Repeater> 
</asp:Content>
