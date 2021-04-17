using DevOpsIntegration.Classes.Info;
using DevOpsIntegration.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevOpsIntegration.Classes.BLL
{
    public class RegistrarBLL
    {
        public void EnviarRegistro(RegistrarInfo info)
        {
            WorkItemService workItem = new WorkItemService();
            workItem.Create(info);
        }
    }
}