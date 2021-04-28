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

            string sqlInsert = string.Format(@"INSERT INTO REGISTRO (cd_registro, cd_tipo_acesso, cd_analista, ds_cliente, ds_palavrachave, ds_motivo, ds_acao, ds_conclusao, ds_sprint, st_bug, vl_inicial, vl_final) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', {8}, {9}, '{10}', '{11}')"
                                            , info.CdRegistro, info.CdTipoAcesso, info.CdAnalista, info.DsCliente, info.DsPalavraChave, info.DsMotivo, info.DsAcao, info.DsConclusao, info.DsSprint, info.StBug, info.VlInicial, info.VlFinal);

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