using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevOpsIntegration.Classes.Info
{
    public class RegistrarInfo
    {
        public int IdRegistro { get; set; }
        public String DsCliente { get; set; }
        public String IdTipoAcesso { get; set; }
        public String DsAnalista { get; set; }
        public String DsPalavraChave { get; set; }
        public String DsMotivo { get; set; }
        public String DsAcao { get; set; }
        public String DsConclusao { get; set; }
        public String DsInfoAdicional { get; set; }
        public bool IsBug { get; set; }
        public TimeSpan DtInicial { get; set; }
        public TimeSpan DtFinal { get; set; }
    }
}