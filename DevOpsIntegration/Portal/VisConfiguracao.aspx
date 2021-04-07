<%@ Page Title="" Language="C#" MasterPageFile="~/Portal/mpSuperior.Master" AutoEventWireup="true" CodeBehind="VisConfiguracao.aspx.cs" Inherits="DevOpsIntegration.Portal.VisConfiguracao" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <html xmlns="http://www.w3.org/1999/xhtml">
    <body>
        <form id="form" runat="server">
            <div class="container-fluid" style="border:1px solid black">
                <div class="row">
                    <div class="col-lg-2" style="border:1px solid red">        
                        <div class="list-group" id="list-tab" role="tablist">
                            <a class="list-group-item list-group-item-action active" id="list-home-list" data-bs-toggle="list" href="#list-home" role="tab" aria-controls="home">Home</a>
                            <a class="list-group-item list-group-item-action" id="list-profile-list" data-bs-toggle="list" href="#list-profile" role="tab" aria-controls="profile">Profile</a>
                            <a class="list-group-item list-group-item-action" id="list-messages-list" data-bs-toggle="list" href="#list-messages" role="tab" aria-controls="messages">Messages</a>
                            <a class="list-group-item list-group-item-action" id="list-settings-list" data-bs-toggle="list" href="#list-settings" role="tab" aria-controls="settings">Settings</a>
                        </div>
                    </div>
                </div>
            </div>
        
            <div class="container-fluid" style="border:1px solid black">
                <div class="row">
                    <div class="col-lg-6" style="border:1px solid red">
                        <asp:Label runat="server" ID="lbURL">URL:</asp:Label>
                        <asp:TextBox runat="server" ID="txtURL" CssClass="form-control"></asp:TextBox>
                        <asp:Label runat="server" ID="lbAcessToken">Access Token:</asp:Label>
                        <asp:TextBox runat="server" ID="txtAcessToken" CssClass="form-control" TextMode="Password"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="container">
                <div class="row">
                    <div class="col-sm">
                        <asp:Button runat="server" ID="btnSalvar" OnClick="btnSalvar_Click" Text="Salvar" CssClass="btn btn-primary w-50 p-1 float-md-end h-70 d-inline-block" />
                    </div>
                </div>
            </div>
        </form>
    </body>
    </html>
</asp:Content>
