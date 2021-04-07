<%@ Page Title="" Language="C#" MasterPageFile="~/Portal/mpSuperior.Master" AutoEventWireup="true" CodeBehind="EsqLateral.aspx.cs" Inherits="DevOpsIntegration.Portal.EsqLateral" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <label> teste</label>
    <!DOCTYPE html>
<html>
  <head>
    <title>Main Page</title>
  </head>
  <body>

    @RenderPage("~/Shared/_Header.cshtml")

    <h1>Index Page Content</h1>
    <p>This is the content of the main page.</p>

    @RenderPage("~/Shared/_Footer.cshtml")

  </body>
</html>
</asp:Content>
