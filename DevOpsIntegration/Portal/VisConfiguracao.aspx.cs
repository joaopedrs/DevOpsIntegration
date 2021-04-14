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
        string _filename = "config.xml";
        string _path = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarDados();
                PreencherDDLSprint();
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            string fullfilepath = string.Format(@"{0}\{1}", _path, _filename);

            ConfiguracaoInfo info = new ConfiguracaoInfo();
            info.DsUrl = txtURL.Text;
            info.DsAccessToken = txtAccessToken.Text;
            info.DsSprintAtiva = dllSprintAtiva.SelectedValue;
            info.DsWorkItem = txtWorkItem.Text;
            info.StChkSprintAtiva = chkSprintAtiva.Checked;

            XmlSerializer xs = new XmlSerializer(typeof(ConfiguracaoInfo));
            using (FileStream fs = new FileStream(fullfilepath, FileMode.Create))
            {
                xs.Serialize(fs, info);
            }
        }

        private void CarregarDados()
        {
            string fullfilepath = string.Format(@"{0}\{1}", _path, _filename);

            try
            {
                ConfiguracaoInfo info;
                XmlSerializer xs = new XmlSerializer(typeof(ConfiguracaoInfo));
                if (File.Exists(fullfilepath))
                {
                    using (FileStream fs = new FileStream(fullfilepath, FileMode.Open, FileAccess.ReadWrite))
                    {
                        info = xs.Deserialize(fs) as ConfiguracaoInfo;
                    }
                    if (info != null)
                    {
                        txtURL.Text = info.DsUrl;
                        txtAccessToken.Text = info.DsAccessToken;
                        dllSprintAtiva.SelectedValue = info.DsSprintAtiva;
                        txtWorkItem.Text = info.DsWorkItem;
                        chkSprintAtiva.Checked = info.StChkSprintAtiva;
                    }
                }
                else
                    LimparCampos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void PreencherDDLSprint()
        {
            IterationBLL bll = new IterationBLL();
            //dllSprintAtiva.DataSource = bll.List();
            var teste = bll.List();
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