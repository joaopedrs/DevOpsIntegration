using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevOpsIntegration.Classes.Info
{
    public class RegistrarInfo
    {
        public int CdRegistro { get; set; }
        public int CdTipoAcesso { get; set; }
        public int CdAnalista { get; set; }

        public String DsCliente { get; set; }
        public String DsPalavraChave { get; set; }
        public String DsMotivo { get; set; }
        public String DsAcao { get; set; }
        public String DsConclusao { get; set; }
        public String DsSprint { get; set; }

        public bool StBug { get; set; }

        public TimeSpan? VlInicial { get; set; }
        public TimeSpan? VlFinal { get; set; }
    }
}

//CREATE TABLE [dbo].[REGISTRO] (
//    [cd_registro] [int] IDENTITY(1, 1) NOT NULL,
//	[cd_tipo_acesso] [int] NOT NULL,
//    [cd_analista] [int] NOT NULL,

//    [ds_cliente] [varchar](50) NULL,
//    [ds_palavrachave] [varchar](300) NULL,
//    [ds_motivo] [varchar](max) NOT NULL,
//	[ds_acao] [varchar](max) NOT NULL,
//	[ds_conclusao] [varchar](max) NOT NULL,
//	[ds_sprint] [varchar](15) NOT NULL,

//    [st_bug] [int] NULL DEFAULT 0,

//    [vl_inicial] [varchar](10) NULL,
//	[vl_final] [varchar](10) NULL,

//    PRIMARY KEY (cd_registro),
//    FOREIGN KEY(cd_tipo_acesso) REFERENCES TIPO_ACESSO(cd_tipo_acesso),
//    FOREIGN KEY(cd_analista) REFERENCES ANALISTA(cd_analista)
//);

//CREATE TABLE [dbo].[ANALISTA] (
//    [cd_analista] [int] IDENTITY(1, 1) NOT NULL,
//	[ds_analista] [varchar](30) NOT NULL,

//    PRIMARY KEY (cd_analista)
//);

//CREATE TABLE [dbo].[TIPO_ACESSO] (
//    [cd_tipo_acesso] [int] IDENTITY(1, 1) NOT NULL,
//	[ds_tipo_acesso] [varchar](30) NOT NULL,

//    PRIMARY KEY (cd_tipo_acesso)
//);
