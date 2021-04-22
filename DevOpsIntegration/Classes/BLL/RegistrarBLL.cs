using DevOpsIntegration.Classes.DAL;
using DevOpsIntegration.Classes.Info;
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
            RegistrarDAL dal = new RegistrarDAL();
            dal.InserirWorkItem(info);
        }
    }
}