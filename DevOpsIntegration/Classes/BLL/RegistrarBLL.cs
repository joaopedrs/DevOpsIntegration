using DevOpsIntegration.Classes.Info;
using DevOpsIntegration.Controller;
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
            WorkItemController workItem = new WorkItemController();
            workItem.Create(info);
        }
    }
}