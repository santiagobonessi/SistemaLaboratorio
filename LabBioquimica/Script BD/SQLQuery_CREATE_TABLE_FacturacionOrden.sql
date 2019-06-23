USE [Prueba_Lab]
GO

/****** Object:  Table [dbo].[FacturacionOrden]    Script Date: 23/06/2019 17:33:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[FacturacionOrden](
	[idFacturacionOrden] [int] IDENTITY(1,1) NOT NULL,
	[idFacturacionMutual] [int] NOT NULL,
	[idPaciente] [int] NOT NULL,
	[usr_ing] [varchar](50) NULL,
	[fec_ing] [date] NULL,
	[usr_mod] [varchar](50) NULL,
	[fec_mod] [date] NULL,
	[usr_baja] [varchar](50) NULL,
	[fec_baja] [date] NULL,
 CONSTRAINT [PK_FacturacionOrden] PRIMARY KEY CLUSTERED 
(
	[idFacturacionOrden] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[FacturacionOrden]  WITH CHECK ADD  CONSTRAINT [FK_FacturacionOrden_FacturacionMutual] FOREIGN KEY([idFacturacionMutual])
REFERENCES [dbo].[FacturacionMutual] ([idFacturacionMutual])
GO

ALTER TABLE [dbo].[FacturacionOrden] CHECK CONSTRAINT [FK_FacturacionOrden_FacturacionMutual]
GO

ALTER TABLE [dbo].[FacturacionOrden]  WITH CHECK ADD  CONSTRAINT [FK_FacturacionOrden_Pacientes] FOREIGN KEY([idPaciente])
REFERENCES [dbo].[Pacientes] ([idPaciente])
GO

ALTER TABLE [dbo].[FacturacionOrden] CHECK CONSTRAINT [FK_FacturacionOrden_Pacientes]
GO


