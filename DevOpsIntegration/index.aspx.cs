﻿using DevOpsIntegration.Classes.BLL;
using DevOpsIntegration.Classes.Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevOpsIntegration
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            RegistrarInfo info = new RegistrarInfo();
            RegistrarBLL registrar = new RegistrarBLL();
            info.DsCliente = txtCliente.Text;
            info.DsTipoAcesso = ddlTipoAcesso.SelectedValue;
            info.DsAnalista = ddlAnalista.SelectedValue;
            info.DsMotivo = txtMotivo.Text;
            info.DsAcao = txtAcao.Text;
            info.DsConclusao = txtConclusao.Text;
            info.DsPalavraChave = txtPalavraChave.Text;
            registrar.EnviarRegistro(info);
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {

        }
    }
}