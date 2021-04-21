using DevOpsIntegration.Classes.BLL;
using DevOpsIntegration.Classes.Info;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DevOpsIntegration.Connection
{
    public class DataBaseConnect
    {
        public SqlConnection Connect()
        {

            ConfiguracaoBLL bll = new ConfiguracaoBLL();
            ConfiguracaoInfo info = bll.Carregar();

            string connetionString = string.Format(@"Data Source={0};Initial Catalog={1};User ID={2};Password={3};", info.DsServidor, info.DsBancoDados, info.DsUsuario, info.DsSenha);
            using (SqlConnection cnn = new SqlConnection(connetionString))
                return cnn;
        }
    }
}