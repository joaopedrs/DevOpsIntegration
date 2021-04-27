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
        public int IdTipoAcesso { get; set; }
        public int IdAnalista { get; set; }
        public String DsPalavraChave { get; set; }
        public String DsMotivo { get; set; }
        public String DsAcao { get; set; }
        public String DsConclusao { get; set; }
        public bool IsBug { get; set; }
        public TimeSpan DtInicial { get; set; }
        public TimeSpan DtFinal { get; set; }
    }
}


//USE[SuporteTI]
//GO

///****** Object:  Table [dbo].[ATENDIMENTOS]    Script Date: 27/04/2021 13:15:53 ******/
//SET ANSI_NULLS ON
//GO

//SET QUOTED_IDENTIFIER ON
//GO

//CREATE TABLE [dbo].[REGISTRO](

//[cd_registro][int] IDENTITY(1, 1) NOT NULL,

//[ds_cliente] [varchar](50) NULL,
//	[cd_tipo_acesso] [int] NOT NULL,

//    [cd_analista] [int] NOT NULL,

//    [ds_palavrachave] [varchar](300) NOT NULL,

//    [ds_motivo] [varchar](max)NOT NULL,
//	[ds_acao] [varchar](max)NOT NULL,
//	[ds_conclusao] [varchar](max)NOT NULL,
//	[st_bug] [int] NULL DEFAULT 0,

//    [vl_inicial] [varchar](15) NULL,
//	[vl_final] [varchar](15) NULL,
//	[ds_sprint] [varchar](15) NOT NULL,
//PRIMARY KEY CLUSTERED 
//(

//    [cd_registro] ASC
//)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
//) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY]
//GO


