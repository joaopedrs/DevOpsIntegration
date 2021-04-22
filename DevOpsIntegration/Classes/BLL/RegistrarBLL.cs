using DevOpsIntegration.Classes.Info;
using DevOpsIntegration.Connection;
using DevOpsIntegration.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DevOpsIntegration.Classes.BLL
{
    public class RegistrarBLL
    {
        public void CriarWorkItem(RegistrarInfo info)
        {
            WorkItemService workItem = new WorkItemService();
            workItem.Create(info);
        }

        public void InserirWorkItem(RegistrarInfo info) 
        {
            ConfiguracaoBLL bll = new ConfiguracaoBLL();
            DataBaseConnect connectionString = new DataBaseConnect();
            string sqlInsert = string.Format(@"INSERT INTO ATENDIMENTOS VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', {8}, {9}, '{10}', '{11}', '{12}', '{13}')"
                                            , info.DsCliente, info.DsAnalista, info.DsPalavraChave, info.DsMotivo, info.DsAcao, info.DsConclusao, info.IdTipoAcesso, null, null, info.IsBug, info.DtInicial, info.DtFinal, null, bll.Carregar().DsSprintAtiva);

            using (SqlConnection cnn = new SqlConnection(connectionString.CreateConnectionString()))
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