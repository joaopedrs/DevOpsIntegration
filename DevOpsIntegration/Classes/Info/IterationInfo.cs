using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevOpsIntegration.Classes.Info
{
    public class IterationInfo
    {
        public int IdIteration { get; set; }
        public String DsNome { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime DtFim { get; set; }
    }
}