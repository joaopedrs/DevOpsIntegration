<%@ Page Title="" Language="C#" MasterPageFile="~/Portal/mpSuperior.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="DevOpsIntegration.index" %>

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
                        <div class="col-sm">
                            <asp:Label runat="server" ID="lbTipoAcesso">Tipo de Acesso:</asp:Label>
                            <asp:DropDownList runat="server" ID="ddlTipoAcesso" CssClass="form-select">
                                <asp:ListItem>Incidente</asp:ListItem>
                                <asp:ListItem>Bug</asp:ListItem>
                                <asp:ListItem>Duvida</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-sm">
                            <asp:Label runat="server" ID="lbAnalista">Analista:</asp:Label>
                            <asp:DropDownList runat="server" ID="ddlAnalista" CssClass="form-select">
                                <asp:ListItem>Adriano</asp:ListItem>
                                <asp:ListItem>Flavio</asp:ListItem>
                                <asp:ListItem>Max</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-sm">
                            <asp:Label runat="server" ID="lbPalavraChave">Palavras-Chave:</asp:Label>
                            <asp:TextBox runat="server" ID="txtPalavraChave" CssClass="form-control"></asp:TextBox>
                            <asp:Label runat="server" ID="lbMotivo">Motivo:</asp:Label>
                            <asp:TextBox runat="server" ID="txtMotivo" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                            <asp:Label runat="server" ID="lbAcao">Ação:</asp:Label>
                            <asp:TextBox runat="server" ID="txtAcao" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                            <asp:Label runat="server" ID="lbConclusao">Conclusão:</asp:Label>
                            <asp:TextBox runat="server" ID="txtConclusao" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="container">
                    <div class="row">
                        <div class="col-7">
                             <asp:CheckBox runat="server" CssClass="form-check-label" ID="chkBug" Checked="false" />
                            <asp:Label runat="server" ID="lbchkBug" AssociatedControlID="chkBug">Gerou Bug</asp:Label>
                        </div>
                        <div class="col-5">
                            <asp:Button runat="server" ID="btnEnviar" OnClick="btnEnviar_Click" Text="Enviar" CssClass="btn btn-primary w-25 p-1 float-md-end h-70 d-inline-block mt-2" />
                            <asp:Button runat="server" ID="btnLimpar" OnClick="btnLimpar_Click" Text="Limpar" CssClass="btn btn-secondary w-25 p-1 float-md-end h-70 d-inline-block me-3 mt-2" />
                        </div>
                    </div>
                </div>
            </form>
        </div>
    </body>
    </html>
</asp:Content>
