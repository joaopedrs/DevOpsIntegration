using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevOpsIntegration.Classes.Info
{
    public class RegistrarInfo
    {
        public String DsCliente { get; set; }
        public String IdTipoAcesso { get; set; }
        public String DsAnalista { get; set; }
        public String DsPalavraChave { get; set; }
        public String DsMotivo { get; set; }
        public String DsAcao { get; set; }
        public String DsConclusao { get; set; }
        public String DsInfoAdicional { get; set; }
        public bool IsBug { get; set; }
        public DateTime DtInicial { get; set; }
        public DateTime DtFinal { get; set; }
    }
}