using DevOpsIntegration.Classes.BLL;
using DevOpsIntegration.Classes.Info;
using DevOpsIntegration.Enum;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            }
        }

        protected void ShowMessage(string Message, MessageTypeEnum type)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), System.Guid.NewGuid().ToString(), "ShowMessage('" + Message + "','" + type + "');", true);
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ConfiguracaoBLL bll = new ConfiguracaoBLL();
                ConfiguracaoInfo info = new ConfiguracaoInfo();
                info.DsUrl = txtURL.Text;
                info.DsAccessToken = txtAccessToken.Text;
                info.DsSprintAtiva = ddlSprintAtiva.SelectedValue;
                info.DsWorkItem = txtWorkItem.Text;
                info.StChkSprintAtiva = chkSprintAtiva.Checked;
                info.DsConnectionString = string.Format(@"Data Source={0};Initial Catalog={1};User ID={2};Password={3};", txtServidor.Text, txtBancoDados.Text, txtUsuario.Text, txtSenha.Text);

                bll.Salvar(info);
                PreencherCampos();
                TestarConexao();
                ShowMessage("Configuração Salva com Sucesso!", MessageTypeEnum.Sucesso);
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message, MessageTypeEnum.Erro);
            }
        }

        private void TestarConexao()
        {
            ConfiguracaoBLL bll = new ConfiguracaoBLL();
            using (SqlConnection cnn = new SqlConnection(bll.Carregar().DsConnectionString))
            {
                cnn.Open();
                cnn.Close();
            }
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
                    SqlConnectionStringBuilder decoder = new SqlConnectionStringBuilder(info.DsConnectionString);
                    txtURL.Text = info.DsUrl;
                    txtAccessToken.Text = info.DsAccessToken;
                    ddlSprintAtiva.SelectedValue = info.StChkSprintAtiva == true ? bllIteration.GetCurrent().IdIteration.ToString() : info.DsSprintAtiva;
                    txtWorkItem.Text = info.DsWorkItem;
                    chkSprintAtiva.Checked = info.StChkSprintAtiva;
                    txtServidor.Text = decoder.DataSource;
                    txtBancoDados.Text = decoder.InitialCatalog;
                    txtUsuario.Text = decoder.UserID;
                    txtSenha.Text = decoder.Password;
                }
                else
                    LimparCampos();
            }
            catch (Exception ex)
            {
                ShowMessage(ex.Message, MessageTypeEnum.Erro);
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