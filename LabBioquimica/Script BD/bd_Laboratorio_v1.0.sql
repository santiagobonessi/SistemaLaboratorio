USE [master]
GO
/****** Object:  Database [Laboratorio]    Script Date: 21/09/2017 6:01:54 ******/
CREATE DATABASE [Laboratorio] ON  PRIMARY 
( NAME = N'Laboratorio', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\Laboratorio.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Laboratorio_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\Laboratorio_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Laboratorio] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Laboratorio].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Laboratorio] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Laboratorio] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Laboratorio] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Laboratorio] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Laboratorio] SET ARITHABORT OFF 
GO
ALTER DATABASE [Laboratorio] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Laboratorio] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Laboratorio] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Laboratorio] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Laboratorio] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Laboratorio] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Laboratorio] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Laboratorio] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Laboratorio] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Laboratorio] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Laboratorio] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Laboratorio] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Laboratorio] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Laboratorio] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Laboratorio] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Laboratorio] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Laboratorio] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Laboratorio] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Laboratorio] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Laboratorio] SET  MULTI_USER 
GO
ALTER DATABASE [Laboratorio] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Laboratorio] SET DB_CHAINING OFF 
GO
USE [Laboratorio]
GO
/****** Object:  Table [dbo].[Analisis]    Script Date: 21/09/2017 6:01:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Analisis](
	[idAnalisis] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [varchar](50) NULL,
	[nombre] [varchar](80) NOT NULL,
	[metodo] [varchar](80) NULL,
	[unidadBioquimica] [float] NULL,
 CONSTRAINT [PK__Analisis__40F9A2071A14E395] PRIMARY KEY CLUSTERED 
(
	[idAnalisis] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AnalisisXItems]    Script Date: 21/09/2017 6:01:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnalisisXItems](
	[idItem] [int] NOT NULL,
	[idAnalisis] [int] NOT NULL,
 CONSTRAINT [PK_AnalisisXItems] PRIMARY KEY CLUSTERED 
(
	[idAnalisis] ASC,
	[idItem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DetalleFacturaMutual]    Script Date: 21/09/2017 6:01:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleFacturaMutual](
	[nroFactura] [int] NOT NULL,
	[idMutual] [int] NOT NULL,
	[idPaciente] [int] NOT NULL,
	[codAnalisis] [int] NOT NULL,
	[subtotal] [float] NOT NULL,
 CONSTRAINT [PK_DetalleFacturaMutual] PRIMARY KEY CLUSTERED 
(
	[nroFactura] ASC,
	[idMutual] ASC,
	[idPaciente] ASC,
	[codAnalisis] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FacturaMutual]    Script Date: 21/09/2017 6:01:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FacturaMutual](
	[numFactura] [int] NOT NULL,
	[idMutual] [int] NOT NULL,
	[fecha] [varchar](50) NOT NULL,
	[precioUnidadBioquimica] [float] NOT NULL,
 CONSTRAINT [PK_FacturaMutual] PRIMARY KEY CLUSTERED 
(
	[numFactura] ASC,
	[idMutual] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Item]    Script Date: 21/09/2017 6:01:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Item](
	[idItem] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](40) NOT NULL,
	[idUnidad] [int] NOT NULL,
	[valorReferencia] [varchar](150) NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[idItem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Localidad]    Script Date: 21/09/2017 6:01:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Localidad](
	[idLocalidad] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[codPostal] [int] NULL,
 CONSTRAINT [PK__Localida__548E364E07020F21] PRIMARY KEY CLUSTERED 
(
	[idLocalidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mutuales]    Script Date: 21/09/2017 6:01:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mutuales](
	[idMutual] [int] IDENTITY(0,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[telefono] [varchar](50) NULL,
	[direccion] [varchar](80) NULL,
	[email] [varchar](100) NULL,
 CONSTRAINT [PK__Mutuales__59E3E53B164452B1] PRIMARY KEY CLUSTERED 
(
	[idMutual] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pacientes]    Script Date: 21/09/2017 6:01:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pacientes](
	[idPaciente] [int] IDENTITY(1,1) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[documento] [int] NULL,
	[idTipoDoc] [int] NULL,
	[idSexo] [int] NULL,
	[telefono] [varchar](50) NULL,
	[idMutual] [int] NULL,
	[idLocalidad] [int] NULL,
	[calle] [varchar](80) NULL,
	[nroCalle] [int] NULL,
 CONSTRAINT [PK__Paciente__F48A08F27F60ED59] PRIMARY KEY CLUSTERED 
(
	[idPaciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Practica]    Script Date: 21/09/2017 6:01:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Practica](
	[idPractica] [int] NOT NULL,
	[idProtocoloDetalle] [int] NOT NULL,
	[idItem] [int] NOT NULL,
	[resultado] [varchar](50) NULL,
 CONSTRAINT [PK_Practica] PRIMARY KEY CLUSTERED 
(
	[idPractica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Profesionales]    Script Date: 21/09/2017 6:01:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Profesionales](
	[idProfesional] [int] IDENTITY(1,1) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[matricula] [varchar](50) NULL,
	[telefono] [varchar](50) NULL,
	[idLocalidad] [int] NULL,
	[calle] [varchar](80) NULL,
	[nroCalle] [int] NULL,
 CONSTRAINT [PK__Profesio__E3AF0B2D1273C1CD] PRIMARY KEY CLUSTERED 
(
	[idProfesional] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Protocolo]    Script Date: 21/09/2017 6:01:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Protocolo](
	[idProtocolo] [int] IDENTITY(1,1) NOT NULL,
	[nroProtocolo] [int] NULL,
	[fecha] [varchar](50) NOT NULL,
	[idPaciente] [int] NOT NULL,
	[idProfesional] [int] NOT NULL,
 CONSTRAINT [PK__Examen__7C12E17E0EA330E9] PRIMARY KEY CLUSTERED 
(
	[idProtocolo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProtocoloDetalle]    Script Date: 21/09/2017 6:01:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProtocoloDetalle](
	[idProtocoloDetalle] [int] NOT NULL,
	[idProtocolo] [int] NOT NULL,
	[idAnalisis] [int] NOT NULL,
 CONSTRAINT [PK_ProtocoloDetalle] PRIMARY KEY CLUSTERED 
(
	[idProtocoloDetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sexo]    Script Date: 21/09/2017 6:01:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sexo](
	[idSexo] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Sexo] PRIMARY KEY CLUSTERED 
(
	[idSexo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoDocumento]    Script Date: 21/09/2017 6:01:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoDocumento](
	[idTipoDoc] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TipoDocumento] PRIMARY KEY CLUSTERED 
(
	[idTipoDoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Unidad]    Script Date: 21/09/2017 6:01:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Unidad](
	[idUnidad] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NOT NULL,
 CONSTRAINT [PK__Unidad__34C1E8D70AD2A005] PRIMARY KEY CLUSTERED 
(
	[idUnidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[AnalisisXItems]  WITH CHECK ADD  CONSTRAINT [FK_AnalisisXItems_Analisis] FOREIGN KEY([idAnalisis])
REFERENCES [dbo].[Analisis] ([idAnalisis])
GO
ALTER TABLE [dbo].[AnalisisXItems] CHECK CONSTRAINT [FK_AnalisisXItems_Analisis]
GO
ALTER TABLE [dbo].[AnalisisXItems]  WITH CHECK ADD  CONSTRAINT [FK_AnalisisXItems_Item] FOREIGN KEY([idItem])
REFERENCES [dbo].[Item] ([idItem])
GO
ALTER TABLE [dbo].[AnalisisXItems] CHECK CONSTRAINT [FK_AnalisisXItems_Item]
GO
ALTER TABLE [dbo].[DetalleFacturaMutual]  WITH CHECK ADD  CONSTRAINT [FK_DetalleFacturaMutual_Analisis] FOREIGN KEY([codAnalisis])
REFERENCES [dbo].[Analisis] ([idAnalisis])
GO
ALTER TABLE [dbo].[DetalleFacturaMutual] CHECK CONSTRAINT [FK_DetalleFacturaMutual_Analisis]
GO
ALTER TABLE [dbo].[DetalleFacturaMutual]  WITH CHECK ADD  CONSTRAINT [FK_DetalleFacturaMutual_FacturaMutual] FOREIGN KEY([nroFactura], [idMutual])
REFERENCES [dbo].[FacturaMutual] ([numFactura], [idMutual])
GO
ALTER TABLE [dbo].[DetalleFacturaMutual] CHECK CONSTRAINT [FK_DetalleFacturaMutual_FacturaMutual]
GO
ALTER TABLE [dbo].[DetalleFacturaMutual]  WITH CHECK ADD  CONSTRAINT [FK_DetalleFacturaMutual_Pacientes] FOREIGN KEY([idPaciente])
REFERENCES [dbo].[Pacientes] ([idPaciente])
GO
ALTER TABLE [dbo].[DetalleFacturaMutual] CHECK CONSTRAINT [FK_DetalleFacturaMutual_Pacientes]
GO
ALTER TABLE [dbo].[FacturaMutual]  WITH CHECK ADD  CONSTRAINT [FK_FacturaMutual_Mutuales] FOREIGN KEY([idMutual])
REFERENCES [dbo].[Mutuales] ([idMutual])
GO
ALTER TABLE [dbo].[FacturaMutual] CHECK CONSTRAINT [FK_FacturaMutual_Mutuales]
GO
ALTER TABLE [dbo].[Item]  WITH CHECK ADD  CONSTRAINT [FK_Item_Unidad] FOREIGN KEY([idUnidad])
REFERENCES [dbo].[Unidad] ([idUnidad])
GO
ALTER TABLE [dbo].[Item] CHECK CONSTRAINT [FK_Item_Unidad]
GO
ALTER TABLE [dbo].[Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Pacientes_Localidad] FOREIGN KEY([idLocalidad])
REFERENCES [dbo].[Localidad] ([idLocalidad])
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK_Pacientes_Localidad]
GO
ALTER TABLE [dbo].[Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Pacientes_Mutuales] FOREIGN KEY([idMutual])
REFERENCES [dbo].[Mutuales] ([idMutual])
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK_Pacientes_Mutuales]
GO
ALTER TABLE [dbo].[Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Pacientes_Sexo] FOREIGN KEY([idSexo])
REFERENCES [dbo].[Sexo] ([idSexo])
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK_Pacientes_Sexo]
GO
ALTER TABLE [dbo].[Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Pacientes_TipoDocumento] FOREIGN KEY([idTipoDoc])
REFERENCES [dbo].[TipoDocumento] ([idTipoDoc])
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK_Pacientes_TipoDocumento]
GO
ALTER TABLE [dbo].[Practica]  WITH CHECK ADD  CONSTRAINT [FK_Practica_Item] FOREIGN KEY([idItem])
REFERENCES [dbo].[Item] ([idItem])
GO
ALTER TABLE [dbo].[Practica] CHECK CONSTRAINT [FK_Practica_Item]
GO
ALTER TABLE [dbo].[Practica]  WITH CHECK ADD  CONSTRAINT [FK_Practica_ProtocoloDetalle] FOREIGN KEY([idProtocoloDetalle])
REFERENCES [dbo].[ProtocoloDetalle] ([idProtocoloDetalle])
GO
ALTER TABLE [dbo].[Practica] CHECK CONSTRAINT [FK_Practica_ProtocoloDetalle]
GO
ALTER TABLE [dbo].[Profesionales]  WITH CHECK ADD  CONSTRAINT [FK_Profesionales_Localidad] FOREIGN KEY([idLocalidad])
REFERENCES [dbo].[Localidad] ([idLocalidad])
GO
ALTER TABLE [dbo].[Profesionales] CHECK CONSTRAINT [FK_Profesionales_Localidad]
GO
ALTER TABLE [dbo].[Protocolo]  WITH CHECK ADD  CONSTRAINT [FK_Protocolo_Pacientes] FOREIGN KEY([idPaciente])
REFERENCES [dbo].[Pacientes] ([idPaciente])
GO
ALTER TABLE [dbo].[Protocolo] CHECK CONSTRAINT [FK_Protocolo_Pacientes]
GO
ALTER TABLE [dbo].[Protocolo]  WITH CHECK ADD  CONSTRAINT [FK_Protocolo_Profesionales] FOREIGN KEY([idProfesional])
REFERENCES [dbo].[Profesionales] ([idProfesional])
GO
ALTER TABLE [dbo].[Protocolo] CHECK CONSTRAINT [FK_Protocolo_Profesionales]
GO
ALTER TABLE [dbo].[ProtocoloDetalle]  WITH CHECK ADD  CONSTRAINT [FK_ProtocoloDetalle_Analisis] FOREIGN KEY([idAnalisis])
REFERENCES [dbo].[Analisis] ([idAnalisis])
GO
ALTER TABLE [dbo].[ProtocoloDetalle] CHECK CONSTRAINT [FK_ProtocoloDetalle_Analisis]
GO
ALTER TABLE [dbo].[ProtocoloDetalle]  WITH CHECK ADD  CONSTRAINT [FK_ProtocoloDetalle_Protocolo] FOREIGN KEY([idProtocolo])
REFERENCES [dbo].[Protocolo] ([idProtocolo])
GO
ALTER TABLE [dbo].[ProtocoloDetalle] CHECK CONSTRAINT [FK_ProtocoloDetalle_Protocolo]
GO
USE [master]
GO
ALTER DATABASE [Laboratorio] SET  READ_WRITE 
GO
