<%@ Page Title="" Language="C#" MasterPageFile="~/Portal/mpSuperior.Master" AutoEventWireup="true" CodeBehind="VisConfiguracao.aspx.cs" Inherits="DevOpsIntegration.Portal.VisConfiguracao" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <html xmlns="http://www.w3.org/1999/xhtml">
    <body>
        <div class="divForm">
            <form id="form" runat="server">
                <div class="container">
                    <div class="row">
                        <div class="col-sm">
                            <asp:Label runat="server" ID="lbCliente">Cliente:</asp:Label>
                            <asp:TextBox runat="server" ID="txtCliente" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="container">
                    <div class="row">
                        <div class="col-sm">
                            <asp:Button runat="server" ID="btnEnviar" OnClick="btnEnviar_Click" Text="Enviar" CssClass="btn btn-primary w-50 p-1 float-md-end h-70 d-inline-block" />
                            <asp:Button runat="server" ID="btnLimpar" OnClick="btnLimpar_Click" Text="Limpar" CssClass="btn btn-secondary w-50 p-1 float-md-end h-70 d-inline-block" />
                        </div>
                    </div>
                </div>
            </form>
        </div>
    </body>
    </html>
</asp:Content>
