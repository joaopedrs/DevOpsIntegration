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

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            // Create an instance of the CustomerData class and populate
            // it with the data from the form.
            ConfiguracaoInfo info = new ConfiguracaoInfo();
            info.DsUrl = txtURL.Text;
            info.DsAccessToken = txtAccessToken.Text;
            info.DsSprintAtiva = dllSprintAtiva.SelectedValue;
            info.DsWorkItem = txtWorkItem.Text;

            // Create and XmlSerializer to serialize the data to a file
            XmlSerializer xs = new XmlSerializer(typeof(ConfiguracaoInfo));
            using (FileStream fs = new FileStream("config.xml", FileMode.Create))
            {
                xs.Serialize(fs, info);
            }
        }

        private void CarregarDados()
        {
            ConfiguracaoInfo info;
            XmlSerializer xs = new XmlSerializer(typeof(ConfiguracaoInfo));
            using (FileStream fs = new FileStream("config.xml", FileMode.Open))
            {
                // This will read the XML from the file and create the new instance
                // of CustomerData
                info = xs.Deserialize(fs) as ConfiguracaoInfo;
            }

            // If the customer data was successfully deserialized we can transfer
            // the data from the instance to the form.
            if (info != null)
            {
                txtURL.Text = info.DsUrl;
                txtAccessToken.Text = info.DsAccessToken;
                dllSprintAtiva.SelectedValue = info.DsSprintAtiva;
                txtWorkItem.Text = info.DsWorkItem;
            }
        }
    }
}