using DevOpsIntegration.Classes.Info;
using DevOpsIntegration.Controller;
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
            IterationController iteration = new IterationController();
            return iteration.List();
        }

        public IterationInfo GetCurrent()
        {
            IterationController iteration = new IterationController();
            return iteration.GetCurrent();
        }
    }
}