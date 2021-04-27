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
                        </div>
                        <div class="col-5">
                            <button type="button" class="btn btn-primary w-25 p-1 float-md-end h-70 d-inline-block mt-2" data-bs-toggle="modal" data-bs-target="#ModalEnviar">Registrar</button>
                            <asp:Button runat="server" ID="btnLimpar" OnClick="btnLimpar_Click" Text="Limpar" CssClass="btn btn-secondary w-25 p-1 float-md-end h-70 d-inline-block me-3 mt-2" />
                        </div>
                    </div>
                </div>
                <div class="modal fade" id="ModalEnviar" tabindex="-1" aria-labelledby="ModalEnviar" aria-hidden="true">
                    <div class="modal-dialog">
                        <div class="modal-content">
                            <div class="modal-header">
                                <h5 class="modal-title" id="lbTitleModal">Registrar Atendimento</h5>
                                <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                            </div>
                            <div class="modal-body">
                                <div class="container-fluid">
                                    <div class="row">
                                        <div class="col-6">
                                            <asp:Label runat="server" ID="lbTimeInicial" CssClass="w-75" AssociatedControlID="txtTimeInicial">Horário Inicial:</asp:Label>
                                            <asp:TextBox runat="server" ID="txtTimeInicial" CssClass=" form-control w-75" TextMode="Time"></asp:TextBox>
                                        </div>
                                        <div class="col-6">
                                            <asp:Label runat="server" ID="lbTimeFinal" CssClass="w-75 float-md-end" AssociatedControlID="txtTimeFinal">Horário Final:</asp:Label>
                                            <asp:TextBox runat="server" ID="txtTimeFinal" CssClass="form-control w-75 float-md-end" TextMode="Time"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="modal-footer">
                                <div class="container-fluid">
                                    <div class="row">
                                        <div class="col">
                                            <asp:CheckBox runat="server" ID="chkIsBug" Checked="false" />
                                            <asp:Label runat="server" CssClass="form-check-label" ID="lbIsBug" AssociatedControlID="chkIsBug">BUG</asp:Label>
                                        </div>
                                        <div class="col">
                                            <asp:Button runat="server" ID="btnRegistrar" OnClick="btnRegistrar_Click" Text="Registrar" CssClass="btn btn-primary float-md-end ms-2" />
                                            <button type="button" class="btn btn-secondary float-md-end" data-bs-dismiss="modal">Cancelar</button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </form>
        </div>
    </body>
    </html>
</asp:Content>
