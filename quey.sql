CREATE DATABASE [Test_Invoice]
GO
USE [Test_Invoice]
GO
/****** Object: Table [dbo].[Customers] Script Date: 1/31/2022 1:00:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
[Id] [int] IDENTITY(1,1) NOT NULL,
[CustName] [nvarchar](70) NOT NULL,
[Adress] [nvarchar](120) NOT NULL,
[Status] [bit] NOT NULL,
[CustomerTypeId] [int] NOT NULL,
CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED
(
[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON,
ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object: Table [dbo].[CustomerTypes] Script Date: 1/31/2022 1:00:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerTypes](
[Id] [int] IDENTITY(1,1) NOT NULL,
[Description] [nvarchar](70) NOT NULL,
CONSTRAINT [PK_CustomerType] PRIMARY KEY CLUSTERED
(
[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON,
ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object: Table [dbo].[Invoice] Script Date: 1/31/2022 1:00:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Invoice](
[Id] [int] IDENTITY(1,1) NOT NULL,
[CustomerId] [int] NOT NULL,
[TotalItbis] [money] NOT NULL,
[SubTotal] [money] NOT NULL,
[Total] [money] NOT NULL,
CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED
(
[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON,
ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object: Table [dbo].[InvoiceDetail] Script Date: 1/31/2022 1:00:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvoiceDetail](
[Id] [int] IDENTITY(1,1) NOT NULL,
[CustomerId] [int] NOT NULL,
[Qty] [int] NOT NULL,
[Price] [money] NOT NULL,
[TotalItbis] [money] NOT NULL,
[SubTotal] [money] NOT NULL,
[Total] [money] NOT NULL,
CONSTRAINT [PK_InvoiceDetail] PRIMARY KEY CLUSTERED
(
[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON,
ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Customers] ADD CONSTRAINT [DF_Customers_Status] DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Customers] ADD CONSTRAINT [DF_Customers_CustomerType] DEFAULT ((1)) FOR
[CustomerTypeId]
GO
ALTER TABLE [dbo].[Invoice] ADD CONSTRAINT [DF_Invoice_TotalItbis] DEFAULT ((0)) FOR [TotalItbis]
GO
ALTER TABLE [dbo].[InvoiceDetail] ADD CONSTRAINT [DF_InvoiceDetail_TotalItbis1] DEFAULT ((0)) FOR [Qty]
GO
ALTER TABLE [dbo].[InvoiceDetail] ADD CONSTRAINT [DF_InvoiceDetail_TotalItbis] DEFAULT ((0)) FOR [TotalItbis]
GO
ALTER TABLE [dbo].[Customers] WITH CHECK ADD CONSTRAINT [FK_Customers_CustomerTypes] FOREIGN

KEY([CustomerTypeId])
REFERENCES [dbo].[CustomerTypes] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customers_CustomerTypes]
GO
ALTER TABLE [dbo].[Invoice] WITH CHECK ADD CONSTRAINT [FK_Invoice_Customers] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Invoice] CHECK CONSTRAINT [FK_Invoice_Customers]
GO
ALTER TABLE [dbo].[InvoiceDetail] WITH CHECK ADD CONSTRAINT [FK_InvoiceDetail_Invoice] FOREIGN
KEY([CustomerId])
REFERENCES [dbo].[Invoice] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[InvoiceDetail] CHECK CONSTRAINT [FK_InvoiceDetail_Invoice]
GO


GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 1/11/2023 7:42:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[usuario] [varchar](20) NOT NULL,
	[clave] [varchar](20) NULL,
	[fecha1] [smalldatetime] NULL,
	[hora1] [varchar](50) NULL,
	[fecha2] [smalldatetime] NULL,
	[hora2] [varchar](50) NULL,
	[condicion] [varchar](20) NULL CONSTRAINT [DF_Usuarios_condicion]  DEFAULT ('A'),
	[perfil] [varchar](20) NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Usuarios] ([usuario], [clave], [fecha1], [hora1], [fecha2], [hora2], [condicion], [perfil]) VALUES (N'ADMINISTRADOR', N'123', CAST(N'1901-01-01 00:00:00' AS SmallDateTime), N'', CAST(N'1901-01-01 00:00:00' AS SmallDateTime), N'', N'ACTIVO', N'Administradores')
INSERT [dbo].[Usuarios] ([usuario], [clave], [fecha1], [hora1], [fecha2], [hora2], [condicion], [perfil]) VALUES (N'CONT01', N'123', CAST(N'2011-01-17 00:00:00' AS SmallDateTime), N'12:00:00 a.m.', CAST(N'2011-01-17 00:00:00' AS SmallDateTime), N'12:00:00 a.m.', N'ACTIVO', N'Contadores')
INSERT [dbo].[Usuarios] ([usuario], [clave], [fecha1], [hora1], [fecha2], [hora2], [condicion], [perfil]) VALUES (N'VEND01', N'123', CAST(N'2016-06-24 00:00:00' AS SmallDateTime), N'12:00:00 a.m.', CAST(N'2016-06-24 00:00:00' AS SmallDateTime), N'12:00:00 a.m.', N'ACTIVO', N'VENDEDORES')
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Perfil] FOREIGN KEY([perfil])
REFERENCES [dbo].[Perfil] ([perfil])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Perfil]
GO




