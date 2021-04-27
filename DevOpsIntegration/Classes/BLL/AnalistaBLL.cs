using DevOpsIntegration.Classes.DAL;
using DevOpsIntegration.Classes.Info;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevOpsIntegration.Classes.BLL
{
    public class AnalistaBLL
    {
        public List<AnalistaInfo> List()
        {
            AnalistaDAL dal = new AnalistaDAL();
            return dal.List();
        }
    }
}