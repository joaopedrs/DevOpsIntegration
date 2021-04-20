using DevOpsIntegration.Classes.BLL;
using DevOpsIntegration.Classes.Info;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevOpsIntegration.Services
{
    public class IterationService
    {
        public List<IterationInfo> List()
        {
            ConfiguracaoBLL bll = new ConfiguracaoBLL();
            ConfiguracaoInfo info = bll.Carregar();

            Uri url = new Uri(info.DsUrl);
            VssCredentials token = new VssCredentials(new Microsoft.VisualStudio.Services.Common.VssBasicCredential(string.Empty, info.DsAccessToken));
            using (VssConnection connection = new VssConnection(url, token))
            {
                using (WorkItemTrackingHttpClient workItemTracking = connection.GetClient<WorkItemTrackingHttpClient>())
                {
                    string teamProjectName = "SHARE-4";
                    var iterationResult = workItemTracking.GetClassificationNodeAsync(teamProjectName, structureGroup: Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models.TreeStructureGroup.Iterations, depth: 2).Result;

                    List<IterationInfo> iterations = new List<IterationInfo>();
                    return iterations = iterationResult.Children
                        .Where(value => value.Attributes != null)
                        .Select(values => new IterationInfo() { IdIteration = values.Id, DsNome = values.Name, DtInicio = (values.Attributes != null) ? Convert.ToDateTime(values.Attributes.ToArray()[0].Value) : DateTime.MinValue, DtFim = (values.Attributes != null) ? Convert.ToDateTime(values.Attributes.ToArray()[1].Value) : DateTime.MinValue }).ToList();
                }
            }
        }

        public IterationInfo GetCurrent()
        {
            return List().FirstOrDefault(value => value.DtInicio <= DateTime.Now.Date && value.DtFim >= DateTime.Now.Date);
        }
    }
}