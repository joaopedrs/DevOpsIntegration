using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevOpsIntegration.Classes.Info
{
    public class ConfiguracaoInfo
    {
        public String DsUrl { get; set; }
        public String DsAccessToken { get; set; }
        public String DsSprintAtiva { get; set; }
        public String DsWorkItem { get; set; }
        public bool StChkSprintAtiva { get; set; }
        public String DsServidor { get; set; }
        public String DsBancoDados { get; set; }
        public String DsUsuario { get; set; }
        public String DsSenha { get; set; }

    }
}