using DevOpsIntegration.Classes.BLL;
using DevOpsIntegration.Classes.Info;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;

namespace DevOpsIntegration.Portal
{
    public partial class VisConfiguracao : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PreencherCampos();
                PreencherDDLSprint();
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            ConfiguracaoBLL bll = new ConfiguracaoBLL();
            ConfiguracaoInfo info = new ConfiguracaoInfo();
            info.DsUrl = txtURL.Text;
            info.DsAccessToken = txtAccessToken.Text;
            //info.DsSprintAtiva = dllSprintAtiva.SelectedValue;
            info.DsWorkItem = txtWorkItem.Text;
            info.StChkSprintAtiva = chkSprintAtiva.Checked;

            bll.Salvar(info);
        }

        private void PreencherCampos()
        {
            ConfiguracaoBLL bll = new ConfiguracaoBLL();
            ConfiguracaoInfo info = bll.Carregar();
            if (info != null)
            {
                txtURL.Text = info.DsUrl;
                txtAccessToken.Text = info.DsAccessToken;
                //dllSprintAtiva.SelectedValue = info.DsSprintAtiva;
                txtWorkItem.Text = info.DsWorkItem;
                chkSprintAtiva.Checked = info.StChkSprintAtiva;
            }
            else
                LimparCampos();
        }

        public void PreencherDDLSprint()
        {
            IterationBLL bll = new IterationBLL();
            dllSprintAtiva.DataSource = bll.List().Select(values => new { IdIteration = values.IdIteration, DsNome = values.DsNome });
            dllSprintAtiva.DataValueField = "IdIteration";
            dllSprintAtiva.DataTextField = "DsNome";
            dllSprintAtiva.DataBind();
        }

        private void LimparCampos()
        {
            txtURL.Text = string.Empty;
            txtAccessToken.Text = string.Empty;
            dllSprintAtiva.SelectedValue = string.Empty;
            txtWorkItem.Text = string.Empty;
            chkSprintAtiva.Checked = true;
        }
    }
}