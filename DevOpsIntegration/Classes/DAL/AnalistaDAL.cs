using DevOpsIntegration.Classes.BLL;
using DevOpsIntegration.Classes.Info;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DevOpsIntegration.Classes.DAL
{
    public class AnalistaDAL
    {
        public void Get(int IdAnalista)
        {

        }

        public List<AnalistaInfo> List()
        {
            ConfiguracaoBLL bllConf = new ConfiguracaoBLL();
            ConfiguracaoInfo infoConf = bllConf.Carregar();
            List<AnalistaInfo> list = new List<AnalistaInfo>();
            string sqlSelect = string.Format(@"SELECT ID_ANALISTA, DS_ANALISTA FROM ANALISTA");

            using (SqlConnection cnn = new SqlConnection(infoConf.DsConnectionString))
            {
                cnn.Open();

                using (SqlCommand command = new SqlCommand(sqlSelect, cnn))
                {
                    SqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        list.Add(new AnalistaInfo()
                        {
                            IdAnalista = Convert.ToInt32(dr["ID_ANALISTA"]),
                            DsAnalista = dr["DS_ANALISTA"].ToString()
                        });
                    }
                    dr.Close();
                    return list;
                }
            }
        }

        public void Inserir(AnalistaInfo info)
        {
            ConfiguracaoBLL bllConf = new ConfiguracaoBLL();
            ConfiguracaoInfo infoConf = bllConf.Carregar();

            string sqlInsert = string.Format(@"INSERT INTO ANALISTA VALUES ('{0}')",
                                            info.DsAnalista);

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