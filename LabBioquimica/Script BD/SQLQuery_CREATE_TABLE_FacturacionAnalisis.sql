USE [Prueba_Lab]
GO

/****** Object:  Table [dbo].[FacturacionAnalisis]    Script Date: 23/06/2019 17:34:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[FacturacionAnalisis](
	[idFacturacionAnalisis] [int] IDENTITY(1,1) NOT NULL,
	[idFacturacionOrden] [int] NOT NULL,
	[idAnalisis] [int] NOT NULL,
	[usr_ing] [varchar](50) NULL,
	[fec_ing] [date] NULL,
	[usr_mod] [varchar](50) NULL,
	[fec_mod] [date] NULL,
	[usr_baja] [varchar](50) NULL,
	[fec_baja] [date] NULL,
 CONSTRAINT [PK_FacturacionAnalisis] PRIMARY KEY CLUSTERED 
(
	[idFacturacionAnalisis] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[FacturacionAnalisis]  WITH CHECK ADD  CONSTRAINT [FK_FacturacionAnalisis_Analisis] FOREIGN KEY([idAnalisis])
REFERENCES [dbo].[Analisis] ([idAnalisis])
GO

ALTER TABLE [dbo].[FacturacionAnalisis] CHECK CONSTRAINT [FK_FacturacionAnalisis_Analisis]
GO

ALTER TABLE [dbo].[FacturacionAnalisis]  WITH CHECK ADD  CONSTRAINT [FK_FacturacionAnalisis_FacturacionOrden] FOREIGN KEY([idFacturacionOrden])
REFERENCES [dbo].[FacturacionOrden] ([idFacturacionOrden])
GO

ALTER TABLE [dbo].[FacturacionAnalisis] CHECK CONSTRAINT [FK_FacturacionAnalisis_FacturacionOrden]
GO


