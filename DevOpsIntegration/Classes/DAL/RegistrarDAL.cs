using DevOpsIntegration.Classes.BLL;
using DevOpsIntegration.Classes.Info;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DevOpsIntegration.Classes.DAL
{
    public class RegistrarDAL
    {
        public void InserirWorkItem(RegistrarInfo info)
        {
            ConfiguracaoBLL bllConf = new ConfiguracaoBLL();
            ConfiguracaoInfo infoConf = bllConf.Carregar();

            string sqlInsert = string.Format(@"INSERT INTO ATENDIMENTOS VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', {8}, {9}, '{10}', '{11}', '{12}', '{13}')"
                                            , info.DsCliente, info.DsAnalista, info.DsPalavraChave, info.DsMotivo, info.DsAcao, info.DsConclusao, info.IdTipoAcesso, null, null, info.IsBug, info.DtInicial, info.DtFinal, null, infoConf.DsSprintAtiva);

            using (SqlConnection cnn = new SqlConnection(infoConf.DsConnectionString))
            {
                cnn.Open();

                using (SqlCommand command = new SqlCommand(sqlInsert, cnn))
                {
                    command.ExecuteNonQuery();
                }

                cnn.Close();
            }


        }
    }
}