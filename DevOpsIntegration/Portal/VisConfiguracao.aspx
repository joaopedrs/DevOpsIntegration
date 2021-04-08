<%@ Page Title="" Language="C#" MasterPageFile="~/Portal/mpSuperior.Master" AutoEventWireup="true" CodeBehind="VisConfiguracao.aspx.cs" Inherits="DevOpsIntegration.Portal.VisConfiguracao" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <html xmlns="http://www.w3.org/1999/xhtml">

    <body>
        <script>
            $(function () {
                $('#home').tab('show')
            })
        </script>
        <div class="divForm" id="divForm">
            <form id="form" runat="server">
                <div class="d-inline-block">
                    <div class="row">
                       <div class="list-group" id="minhaLista" role="tablist">
  <a class="list-group-item list-group-item-action active" data-toggle="list" href="#home" role="tab">Home</a>
  <a class="list-group-item list-group-item-action" data-toggle="list" href="#perfil" role="tab">Perfil</a>
  <a class="list-group-item list-group-item-action" data-toggle="list" href="#mensagens" role="tab">Mensagens</a>
  <a class="list-group-item list-group-item-action" data-toggle="list" href="#configuracoes" role="tab">Configurações</a>
</div>

<div class="tab-content">
  <div class="tab-pane active" id="home" role="tabpanel">.1..</div>
  <div class="tab-pane" id="perfil" role="tabpanel">.3..</div>
  <div class="tab-pane" id="mensagens" role="tabpanel">..2.</div>
  <div class="tab-pane" id="configuracoes" role="tabpanel">5...</div>
</div>

<script>
    $(function () {
        $('#minhaLista a').on('click', function (e) {
            e.preventDefault()
            $(this).tab('show')
        })
    })
</script>
                    </div>
                </div>
                <div class="container">
                    <div class="row">
                        <div class="col-sm">
                            <%--<asp:Button runat="server" ID="btnEnviar" OnClick="btnEnviar_Click" Text="Enviar" CssClass="btn btn-primary w-50 p-1 float-md-end h-70 d-inline-block" />
                            <asp:Button runat="server" ID="btnLimpar" OnClick="btnLimpar_Click" Text="Limpar" CssClass="btn btn-secondary w-50 p-1 float-md-end h-70 d-inline-block" />--%>
                        </div>
                    </div>
                </div>
            </form>
        </div>
    </body>
    </html>
</asp:Content>