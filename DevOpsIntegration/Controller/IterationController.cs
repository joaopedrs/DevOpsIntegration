using DevOpsIntegration.Classes.Info;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevOpsIntegration.Controller
{
    public class IterationController
    {
        public string GetCurrent()
        {
            Uri url = new Uri("https://dev.azure.com/selbettidev");
            VssCredentials token = new VssCredentials(new Microsoft.VisualStudio.Services.Common.VssBasicCredential(string.Empty, "xxx"));
            var connection = new VssConnection(url, token);

            var workItemTracking = connection.GetClient<WorkItemTrackingHttpClient>();
            Microsoft.TeamFoundation.Core.WebApi.ProjectHttpClient projClient = connection.GetClientAsync<Microsoft.TeamFoundation.Core.WebApi.ProjectHttpClient>().Result;
            string teamProjectName = "SHARE-4";
            var iteration = workItemTracking.GetClassificationNodeAsync(teamProjectName, structureGroup: Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models.TreeStructureGroup.Iterations, depth: 2).Result;

            List<IterationInfo> iterations = new List<IterationInfo>();
            iterations = iteration.Children.Select(name => new IterationInfo() { IdIteration = name.Id, DsNome = name.Name, DtInicio = (name.Attributes != null) ? Convert.ToDateTime(name.Attributes.ToArray()[0].Value) : DateTime.MinValue, DtFim = (name.Attributes != null) ? Convert.ToDateTime(name.Attributes.ToArray()[1].Value) : DateTime.MinValue }).ToList();
           
            return GetIteration(iteration);
        }

        private string GetIteration(Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models.WorkItemClassificationNode currentIteration)
        {
            Console.WriteLine(currentIteration.Name);
            if (currentIteration.Children != null)
            {
                foreach (var ci in currentIteration.Children)
                {
                    if (ci.Attributes != null)
                    {
                        //Busca current pela data de inicio, a fim de evitar que o PO não coloque a Sprint em Current
                        if (Convert.ToDateTime(ci.Attributes.ToArray()[0].Value) <= DateTime.Now.Date && Convert.ToDateTime(ci.Attributes.ToArray()[1].Value) >= DateTime.Now.Date)
                        {
                            return ci.Name.ToString();
                        }
                    }
                }
                throw new Exception();
            }
            else
                throw new Exception();
        }
    }
}