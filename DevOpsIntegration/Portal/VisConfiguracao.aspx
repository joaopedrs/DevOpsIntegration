<%@ Page Title="" Language="C#" MasterPageFile="~/Portal/mpSuperior.Master" AutoEventWireup="true" CodeBehind="VisConfiguracao.aspx.cs" Inherits="DevOpsIntegration.Portal.VisConfiguracao" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <html xmlns="http://www.w3.org/1999/xhtml">
    <body>
        <div class="divForm">
            <form id="form" runat="server">
                <div class="container-fluid px-0">
                    <div class="row">
                        <div class="col-2">
                            <div class="d-inline-block">
                                <div class="list-group" id="minhaLista" role="tablist">
                                    <a class="list-group-item list-group-item-action active" data-toggle="list" href="#autorizacao" role="tab">Autorização</a>
                                    <a class="list-group-item list-group-item-action" data-toggle="list" href="#sprint" role="tab">Sprint</a>
                                    <a class="list-group-item list-group-item-action" data-toggle="list" href="#bancodados" role="tab">Banco de dados</a>
                                </div>
                            </div>
                        </div>
                        <div class="col-9">
                            <div class="tab-content">
                                <div class="tab-pane active" id="autorizacao" role="tabpanel">
                                    <asp:Label runat="server" ID="lbURL" AssociatedControlID="txtURL">DevOps URL:</asp:Label>
                                    <asp:TextBox runat="server" ID="txtURL" CssClass="form-control" TextMode="Url"></asp:TextBox>
                                    <asp:Label runat="server" ID="lbAccessToken" AssociatedControlID="txtAccessToken">Access Token:</asp:Label>
                                    <asp:TextBox runat="server" ID="txtAccessToken" CssClass="form-control"></asp:TextBox>
                                </div>
                                <div class="tab-pane" id="sprint" role="tabpanel">
                                    <div>
                                        <asp:Label runat="server" ID="lbSprintAtiva" AssociatedControlID="ddlSprintAtiva">Sprint Ativa:</asp:Label>
                                        <asp:DropDownList runat="server" CssClass="form-select" ID="ddlSprintAtiva">
                                        </asp:DropDownList>

                                        <asp:CheckBox runat="server" CssClass="form-check-label" ID="chkSprintAtiva" Checked="true" />
                                        <asp:Label runat="server" ID="lbchkSprintAtiva" AssociatedControlID="chkSprintAtiva">Buscar Sprint Automaticamente</asp:Label>
                                    </div>
                                    <div>
                                        <asp:Label runat="server" ID="lbWorkItem" AssociatedControlID="txtWorkItem">Principal WorkItem:</asp:Label>
                                        <img src="../Estilos/Icones/info.png" width="15" height="15" data-toggle="tooltip" data-placement="top" title="(Descrição) WorkItem onde serão adicionado as tasks." />
                                        <asp:TextBox runat="server" ID="txtWorkItem" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="tab-pane" id="bancodados" role="tabpanel">
                                    <asp:Label runat="server" ID="lbServidor" AssociatedControlID="txtServidor">Servidor:</asp:Label>
                                    <asp:TextBox runat="server" ID="txtServidor" CssClass="form-control"></asp:TextBox>
                                    <asp:Label runat="server" ID="lbBancoDados" AssociatedControlID="txtBancoDados">Banco de Dados:</asp:Label>
                                    <asp:TextBox runat="server" ID="txtBancoDados" CssClass="form-control"></asp:TextBox>
                                    <asp:Label runat="server" ID="lbUsuario" AssociatedControlID="txtUsuario">Usuário:</asp:Label>
                                    <asp:TextBox runat="server" ID="txtUsuario" CssClass="form-control"></asp:TextBox>
                                    <asp:Label runat="server" ID="lbSenha" AssociatedControlID="txtSenha">Senha:</asp:Label>
                                    <asp:TextBox runat="server" ID="txtSenha" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="divForm">
                                <asp:Button Text="Salvar" runat="server" ID="btnSalvar" OnClick="btnSalvar_Click" CssClass="btn btn-primary mb-3" />
                            </div>
                        </div>
                        <div class="messagealert" id="alert_container"></div>
                    </div>
                </div>
            </form>
        </div>
    </body>
    </html>
</asp:Content>
