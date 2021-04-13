﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Portal/mpSuperior.Master" AutoEventWireup="true" CodeBehind="VisConfiguracao.aspx.cs" Inherits="DevOpsIntegration.Portal.VisConfiguracao" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <html xmlns="http://www.w3.org/1999/xhtml">
    <body>
        <div class="divForm">
            <form id="form" runat="server">
                <div class="row">
                    <div class="col-2">
                        <div class="d-inline-block">
                            <div class="list-group" id="minhaLista" role="tablist">
                                <a class="list-group-item list-group-item-action active" data-toggle="list" href="#home" role="tab">Home</a>
                                <a class="list-group-item list-group-item-action" data-toggle="list" href="#perfil" role="tab">Perfil</a>
                                <a class="list-group-item list-group-item-action" data-toggle="list" href="#mensagens" role="tab">Mensagens</a>
                                <a class="list-group-item list-group-item-action" data-toggle="list" href="#configuracoes" role="tab">Configurações</a>
                            </div>
                        </div>
                    </div>
                    <div class="col-9">
                        <div class="tab-content">
                            <div class="tab-pane active" id="home" role="tabpanel">
                                <asp:Label runat="server" ID="lbCliente">Cliente:</asp:Label>
                                <asp:TextBox runat="server" ID="txtCliente" CssClass="form-control"></asp:TextBox>
                            </div>
                            <div class="tab-pane" id="perfil" role="tabpanel">
                                .2..
                            </div>
                            <div class="tab-pane" id="mensagens" role="tabpanel">
                                ..3.
                            </div>
                            <div class="tab-pane" id="configuracoes" role="tabpanel">
                                4...
                            </div>
                        </div>
                    </div>
                        <div class="col-1"></div>
                  </div>
            </form>
        </div>
    </body>
    </html>
</asp:Content>