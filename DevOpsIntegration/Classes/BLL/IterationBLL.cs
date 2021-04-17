using DevOpsIntegration.Classes.Info;
using DevOpsIntegration.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevOpsIntegration.Classes.BLL
{
    public class IterationBLL
    {
        public List<IterationInfo> List()
        {
            IterationService iteration = new IterationService();
            return iteration.List();
        }

        public IterationInfo GetCurrent()
        {
            IterationService iteration = new IterationService();
            return iteration.GetCurrent();
        }
    }
}