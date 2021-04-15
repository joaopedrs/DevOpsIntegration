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
        public List<IterationInfo> List()
        {
            Uri url = new Uri("https://dev.azure.com/selbettidev");
            VssCredentials token = new VssCredentials(new Microsoft.VisualStudio.Services.Common.VssBasicCredential(string.Empty, "xxx"));
            VssConnection connection = new VssConnection(url, token);

            WorkItemTrackingHttpClient workItemTracking = connection.GetClient<WorkItemTrackingHttpClient>();
            Microsoft.TeamFoundation.Core.WebApi.ProjectHttpClient projClient = connection.GetClientAsync<Microsoft.TeamFoundation.Core.WebApi.ProjectHttpClient>().Result;
            string teamProjectName = "SHARE-4";
            var iterationResult = workItemTracking.GetClassificationNodeAsync(teamProjectName, structureGroup: Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models.TreeStructureGroup.Iterations, depth: 2).Result;

            List<IterationInfo> iterations = new List<IterationInfo>();
            return iterations = iterationResult.Children
                .Where(value => value.Attributes != null)
                .Select(values => new IterationInfo() { IdIteration = values.Id, DsNome = values.Name, DtInicio = (values.Attributes != null) ? Convert.ToDateTime(values.Attributes.ToArray()[0].Value) : DateTime.MinValue, DtFim = (values.Attributes != null) ? Convert.ToDateTime(values.Attributes.ToArray()[1].Value) : DateTime.MinValue }).ToList();
        }

        public IterationInfo GetCurrent()
        {
            return List().FirstOrDefault(value => value.DtInicio <= DateTime.Now.Date && value.DtFim >= DateTime.Now.Date);
        }
    }
}