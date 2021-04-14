<%@ Page Title="" Language="C#" MasterPageFile="~/Portal/mpSuperior.Master" AutoEventWireup="true" CodeBehind="VisConfiguracao.aspx.cs" Inherits="DevOpsIntegration.Portal.VisConfiguracao" %>

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
                                <a class="list-group-item list-group-item-action active" data-toggle="list" href="#autorizacao" role="tab">Autorização</a>
                                <a class="list-group-item list-group-item-action" data-toggle="list" href="#sprint" role="tab">Sprint</a>
                            </div>
                        </div>
                    </div>
                    <div class="col-9">
                        <div class="tab-content">
                            <div class="tab-pane active" id="autorizacao" role="tabpanel">
                                <asp:Label runat="server" ID="lbURL">DevOps URL:</asp:Label>
                                <asp:TextBox runat="server" ID="txtURL" CssClass="form-control"></asp:TextBox>
                                <asp:Label runat="server" ID="lbAccessToken">Access Token:</asp:Label>
                                <asp:TextBox runat="server" ID="txtAccessToken" CssClass="form-control" TextMode="Password"></asp:TextBox>
                            </div>
                            <div class="tab-pane" id="sprint" role="tabpanel">
                                <asp:Label runat="server" ID="lbSprintAtiva">Sprint Ativa:</asp:Label>
                                <asp:DropDownList runat="server" CssClass="form-select" ID="dllSprintAtiva">
                                    <asp:ListItem>1</asp:ListItem>
                                    <asp:ListItem>2</asp:ListItem>
                                </asp:DropDownList>
                                <div class="form-check">
                                    <input class="form-check-input" type="checkbox" value="" id="chkSprintAtiva" checked>
                                    <label class="form-check-label" for="chkSprintAtiva">
                                        Buscar Sprint Automaticamente
                                    </label>
                                </div>
                                <asp:Label runat="server" ID="lbWorkItem">Principal WorkItem:</asp:Label>
                                <img src="../Estilos/Icones/info.png" width="15" height="15" data-toggle="tooltip" data-placement="top" title="(Descrição) WorkItem onde serão adicionado as tasks." />
                                <asp:TextBox runat="server" ID="txtWorkItem" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="divForm">
                            <asp:Button Text="Salvar" runat="server" ID="btnSalvar" OnClick="btnSalvar_Click" CssClass="btn btn-primary mb-3" />
                        </div>
                    </div>
                </div>
                <div class="col-1"></div>
            </form>
        </div>
    </body>
    </html>
</asp:Content>