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
        public string List()
        {
            IterationController iteration = new IterationController();
            return iteration.GetCurrent();
        }

        public void Get(IterationInfo info)
        {
            IterationController iteration = new IterationController();
            //iteration.Get(info);
        }
    }
}