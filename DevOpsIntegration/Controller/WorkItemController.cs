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
    public class WorkItemController
    {
        public void Create(RegistrarInfo info)
        {
            Uri url = new Uri("https://dev.azure.com/selbettidev");
            VssCredentials token = new VssCredentials(new Microsoft.VisualStudio.Services.Common.VssBasicCredential(string.Empty, "xxx"));
            var connection = new VssConnection(url, token);

            var workitemClient = connection.GetClient<WorkItemTrackingHttpClient>();
            var workitemtype = "Task";
            string teamProjectName = "SHARE-4";
            var document = new Microsoft.VisualStudio.Services.WebApi.Patch.Json.JsonPatchDocument();
            document.Add(
                new Microsoft.VisualStudio.Services.WebApi.Patch.Json.JsonPatchOperation()
                {
                    Path = "/fields/System.Title",
                    Operation = Microsoft.VisualStudio.Services.WebApi.Patch.Operation.Add,
                    Value = info.DsTipoAcesso + " | " + info.DsAnalista + " | " + info.DsCliente + " | " + info.DsPalavraChave
                });
            document.Add(
                new Microsoft.VisualStudio.Services.WebApi.Patch.Json.JsonPatchOperation()
                {
                    Path = "/fields/System.IterationPath",
                    Operation = Microsoft.VisualStudio.Services.WebApi.Patch.Operation.Add,
                    Value = string.Format("{0}\\{1}", teamProjectName, "Sprint 36")
                });
            document.Add(new Microsoft.VisualStudio.Services.WebApi.Patch.Json.JsonPatchOperation()
            {
                Path = "/fields/System.AreaPath",
                Operation = Microsoft.VisualStudio.Services.WebApi.Patch.Operation.Add,
                Value = string.Format("{0}\\{1}", teamProjectName, "CHAMADOS")
            });
            document.Add(
                new Microsoft.VisualStudio.Services.WebApi.Patch.Json.JsonPatchOperation()
                {
                    Path = "/relations/-",
                    Operation = Microsoft.VisualStudio.Services.WebApi.Patch.Operation.Add,
                    Value = new
                    {
                        rel = "System.LinkTypes.Hierarchy-Reverse",
                        url = "https://dev.azure.com/selbettidev/0d39a57d-0795-4ac7-9d84-4b05f068c3d7/_apis/wit/workItems/9435"
                    }
                });
            document.Add(
                new Microsoft.VisualStudio.Services.WebApi.Patch.Json.JsonPatchOperation()
                {
                    Path = "/fields/System.Description",
                    Operation = Microsoft.VisualStudio.Services.WebApi.Patch.Operation.Add,
                    Value = "<div><span style=\"color:rgb(34, 34, 34);font-family:&quot;Segoe UI&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, Verdana;font-size:12px;font-weight:bold;\"></span><span style=\"box-sizing:border-box;font-family:&quot;Segoe UI&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, Verdana;font-weight:bold;\">" +
                                "MOTIVO DO ACESSO:" +
                            "</span><div style=\"box-sizing:border-box;font-weight:400;font-family:&quot;Segoe UI&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, Verdana;\">" +
                                    info.DsMotivo +
                            "</div><div style=\"box-sizing:border-box;font-weight:400;font-family:&quot;Segoe UI&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, Verdana;\"><br style=\"box-sizing:border-box;\"></div><div style=\"box-sizing:border-box;font-weight:400;font-family:&quot;Segoe UI&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, Verdana;\"><span style=\"box-sizing:border-box;font-weight:bold;\">" +
                                "O QUE FOI FEITO (AÇÕES):" +
                            "</span></div><div style=\"box-sizing:border-box;font-weight:400;font-family:&quot;Segoe UI&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, Verdana;\">" +
                                    info.DsAcao +
                            "</div><div style=\"box-sizing:border-box;font-weight:400;font-family:&quot;Segoe UI&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, Verdana;\"><br style=\"box-sizing:border-box;\"></div><div style=\"box-sizing:border-box;font-weight:400;font-family:&quot;Segoe UI&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, Verdana;\"><span style=\"box-sizing:border-box;font-weight:bold;\">" +
                                "CONCLUSÃO:" +
                            "</span></div><div style=\"box-sizing:border-box;font-weight:400;font-family:&quot;Segoe UI&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, Verdana;\">" +
                                    info.DsConclusao +
                            "</div><div style=\"box-sizing:border-box;font-weight:400;font-family:&quot;Segoe UI&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, Verdana;\"><br style=\"box-sizing:border-box;\"></div><span style=\"box-sizing:border-box;font-family:&quot;Segoe UI&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, Verdana;font-weight:bold;\">" +
                                "INFORMAÇÕES ADICIONAIS:" +
                            "</span><div style=\"box-sizing:border-box;font-weight:400;font-family:&quot;Segoe UI&quot;, &quot;Helvetica Neue&quot;, Helvetica, Arial, Verdana;\">" +
                                    info.DsInfoAdicional +
                            "</div><br></div>"
                });
            var workitem = workitemClient.CreateWorkItemAsync(document, teamProjectName, workitemtype).Result;
        }
    }
}