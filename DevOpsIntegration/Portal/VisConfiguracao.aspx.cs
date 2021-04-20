using DevOpsIntegration.Classes.BLL;
using DevOpsIntegration.Classes.Info;
using Microsoft.TeamFoundation.Test.WebApi;
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
        public enum MessageType { Success, Error, Info, Warning };
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PreencherCampos();
            }
        }

        protected void ShowMessage(string Message, MessageType type)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), System.Guid.NewGuid().ToString(), "ShowMessage('" + Message + "','" + type + "');", true);
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {

            ShowMessage("TestexD", MessageType.Error);
            ConfiguracaoBLL bll = new ConfiguracaoBLL();
            ConfiguracaoInfo info = new ConfiguracaoInfo();
            info.DsUrl = txtURL.Text;
            info.DsAccessToken = txtAccessToken.Text;
            info.DsSprintAtiva = ddlSprintAtiva.SelectedValue;
            info.DsWorkItem = txtWorkItem.Text;
            info.StChkSprintAtiva = chkSprintAtiva.Checked;

            bll.Salvar(info);
            PreencherCampos();
        }

        private void PreencherCampos()
        {
            try
            {
                PreencherDDLSprint();
                ConfiguracaoBLL bll = new ConfiguracaoBLL();
                ConfiguracaoInfo info = bll.Carregar();
                IterationBLL bllIteration = new IterationBLL();

                if (info != null)
                {
                    txtURL.Text = info.DsUrl;
                    txtAccessToken.Text = info.DsAccessToken;
                    ddlSprintAtiva.SelectedValue = info.StChkSprintAtiva == true ? bllIteration.GetCurrent().IdIteration.ToString() : info.DsSprintAtiva;
                    txtWorkItem.Text = info.DsWorkItem;
                    chkSprintAtiva.Checked = info.StChkSprintAtiva;
                }
                else
                    LimparCampos();
            }
            catch(Exception ex)
            {
                ShowMessage(ex.Message, MessageType.Error);
            }
        }

        public void PreencherDDLSprint()
        {
            IterationBLL bll = new IterationBLL();
            ddlSprintAtiva.DataSource = bll.List().Select(values => new { values.IdIteration, values.DsNome });
            ddlSprintAtiva.DataValueField = "IdIteration";
            ddlSprintAtiva.DataTextField = "DsNome";
            ddlSprintAtiva.DataBind();
        }

        private void LimparCampos()
        {
            txtURL.Text = string.Empty;
            txtAccessToken.Text = string.Empty;
            ddlSprintAtiva.SelectedValue = string.Empty;
            txtWorkItem.Text = string.Empty;
            chkSprintAtiva.Checked = true;
        }
    }
}