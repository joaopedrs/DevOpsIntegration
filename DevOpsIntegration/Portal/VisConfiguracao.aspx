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
                                <select class="form-select" aria-label="Default select example" id="OpcSprintAtiva">
                                    <option selected>Open this select menu</option>
                                    <option value="1">One</option>
                                    <option value="2">Two</option>
                                    <option value="3">Three</option>
                                </select>
                                <div class="form-check">
                                    <input class="form-check-input" type="checkbox" value="" id="chkSprintAtiva" checked>
                                    <label class="form-check-label" for="chkSprintAtiva">
                                        Buscar Sprint Automaticamente
                                    </label>
                                </div>
                                <asp:Label runat="server" ID="lbWorkItem">Principal WorkItem:</asp:Label>
                                <asp:TextBox runat="server" ID="txtWorkItem" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-1"></div>
            </form>
        </div>
    </body>
    </html>
</asp:Content>