<%@ Page Title="" Language="C#" MasterPageFile="~/Portal/mpSuperior.Master" AutoEventWireup="true" CodeBehind="VisConfiguracao.aspx.cs" Inherits="DevOpsIntegration.Portal.VisConfiguracao" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <html xmlns="http://www.w3.org/1999/xhtml">
    <body>
        <%--<style type="text/css">
        .messagealert {
            border:1px solid black;
/*
            width: 100%;
            position: fixed;
             top:0px;
            z-index: 100000;
            padding: 0;
            font-size: 15px;*/
        }
    </style>
         <script type="text/javascript">
             function ShowMessage(message, messagetype) {
                 var cssclass;
                 switch (messagetype) {
                     case 'Success':
                         cssclass = 'alert-success'
                         break;
                     case 'Error':
                         cssclass = 'alert-danger'
                         break;
                     case 'Warning':
                         cssclass = 'alert-warning'
                         break;
                     default:
                         cssclass = 'alert-info'
                 }
                 $('.divForm #alert_container').append('<div id="alert_div" style="margin: 0 0.5%; -webkit-box-shadow: 3px 4px 6px #999;" class="alert ' + cssclass + ' fade in"><a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a><strong>' + messagetype + '!</strong> <span>' + message + '</span></div>');

                 setTimeout(function () {
                     $("#alert_div").fadeTo(4000, 500).slideUp(500, function () {
                         $("#alert_div").remove();
                     });
                 }, 500);//500=0,5 seconds to open
             }
         </script>--%>
        
        <div class="divForm">
            <%--<div class="messagealert" id="alert_container">teste
            </div>--%>
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