USE [Prueba_Lab]
GO

/****** Object:  Table [dbo].[FacturacionMutual]    Script Date: 23/06/2019 17:32:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[FacturacionMutual](
	[idFacturacionMutual] [int] IDENTITY(1,1) NOT NULL,
	[idMutual] [int] NOT NULL,
	[idFacturacionMes] [int] NOT NULL,
	[precioUnidadBioquimica] [decimal](18, 2) NOT NULL,
	[usr_ing] [varchar](50) NULL,
	[fec_ing] [date] NULL,
	[usr_mod] [varchar](50) NULL,
	[fec_mod] [date] NULL,
	[usr_baja] [varchar](50) NULL,
	[fec_baja] [date] NULL,
 CONSTRAINT [PK_FacturacionMutual] PRIMARY KEY CLUSTERED 
(
	[idFacturacionMutual] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[FacturacionMutual]  WITH CHECK ADD  CONSTRAINT [FK_FacturacionMutual_FacturacionMes] FOREIGN KEY([idFacturacionMes])
REFERENCES [dbo].[FacturacionMes] ([idFacturacionMes])
GO

ALTER TABLE [dbo].[FacturacionMutual] CHECK CONSTRAINT [FK_FacturacionMutual_FacturacionMes]
GO

ALTER TABLE [dbo].[FacturacionMutual]  WITH CHECK ADD  CONSTRAINT [FK_FacturacionMutual_Mutuales] FOREIGN KEY([idMutual])
REFERENCES [dbo].[Mutuales] ([idMutual])
GO

ALTER TABLE [dbo].[FacturacionMutual] CHECK CONSTRAINT [FK_FacturacionMutual_Mutuales]
GO


