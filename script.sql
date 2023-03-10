USE [Test_Invoice]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 1/12/2023 4:24:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustName] [nvarchar](70) NOT NULL,
	[Adress] [nvarchar](120) NOT NULL,
	[Status] [bit] NOT NULL CONSTRAINT [DF_Customers_Status]  DEFAULT ((1)),
	[CustomerTypeId] [int] NOT NULL CONSTRAINT [DF_Customers_CustomerType]  DEFAULT ((1)),
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CustomerTypes]    Script Date: 1/12/2023 4:24:03 PM ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 1/12/2023 4:24:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[TotalItbis] [money] NOT NULL CONSTRAINT [DF_Invoice_TotalItbis]  DEFAULT ((0)),
	[SubTotal] [money] NOT NULL,
	[Total] [money] NOT NULL,
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[InvoiceDetail]    Script Date: 1/12/2023 4:24:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvoiceDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[Qty] [int] NOT NULL CONSTRAINT [DF_InvoiceDetail_TotalItbis1]  DEFAULT ((0)),
	[Price] [money] NOT NULL,
	[TotalItbis] [money] NOT NULL CONSTRAINT [DF_InvoiceDetail_TotalItbis]  DEFAULT ((0)),
	[SubTotal] [money] NOT NULL,
	[Total] [money] NOT NULL,
 CONSTRAINT [PK_InvoiceDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 1/12/2023 4:24:03 PM ******/
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
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([Id], [CustName], [Adress], [Status], [CustomerTypeId]) VALUES (1, N'TULIO MANUEL', N'SANTO DOMINGO', 1, 1)
INSERT [dbo].[Customers] ([Id], [CustName], [Adress], [Status], [CustomerTypeId]) VALUES (2, N'JOSE JUAN', N'AZUA', 1, 2)
SET IDENTITY_INSERT [dbo].[Customers] OFF
SET IDENTITY_INSERT [dbo].[CustomerTypes] ON 

INSERT [dbo].[CustomerTypes] ([Id], [Description]) VALUES (1, N'CLIENTE FIJO')
INSERT [dbo].[CustomerTypes] ([Id], [Description]) VALUES (2, N'CLIENTE DIRECTO')
SET IDENTITY_INSERT [dbo].[CustomerTypes] OFF
SET IDENTITY_INSERT [dbo].[Invoice] ON 

INSERT [dbo].[Invoice] ([Id], [CustomerId], [TotalItbis], [SubTotal], [Total]) VALUES (5, 1, 54.0000, 300.0000, 354.0000)
SET IDENTITY_INSERT [dbo].[Invoice] OFF
SET IDENTITY_INSERT [dbo].[InvoiceDetail] ON 

INSERT [dbo].[InvoiceDetail] ([Id], [CustomerId], [Qty], [Price], [TotalItbis], [SubTotal], [Total]) VALUES (15, 5, 12, 25.0000, 54.0000, 300.0000, 354.0000)
SET IDENTITY_INSERT [dbo].[InvoiceDetail] OFF
INSERT [dbo].[Usuarios] ([usuario], [clave], [fecha1], [hora1], [fecha2], [hora2], [condicion], [perfil]) VALUES (N'ADMINISTRADOR', N'123', CAST(N'1901-01-01 00:00:00' AS SmallDateTime), N'', CAST(N'1901-01-01 00:00:00' AS SmallDateTime), N'', N'ACTIVO', N'Administradores')
INSERT [dbo].[Usuarios] ([usuario], [clave], [fecha1], [hora1], [fecha2], [hora2], [condicion], [perfil]) VALUES (N'CONT01', N'123', CAST(N'2011-01-17 00:00:00' AS SmallDateTime), N'12:00:00 a.m.', CAST(N'2011-01-17 00:00:00' AS SmallDateTime), N'12:00:00 a.m.', N'ACTIVO', N'Contadores')
INSERT [dbo].[Usuarios] ([usuario], [clave], [fecha1], [hora1], [fecha2], [hora2], [condicion], [perfil]) VALUES (N'VEND01', N'123', CAST(N'2016-06-24 00:00:00' AS SmallDateTime), N'12:00:00 a.m.', CAST(N'2016-06-24 00:00:00' AS SmallDateTime), N'12:00:00 a.m.', N'ACTIVO', N'VENDEDORES')
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customers_CustomerTypes] FOREIGN KEY([CustomerTypeId])
REFERENCES [dbo].[CustomerTypes] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customers_CustomerTypes]
GO
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Customers] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Invoice] CHECK CONSTRAINT [FK_Invoice_Customers]
GO
ALTER TABLE [dbo].[InvoiceDetail]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceDetail_Invoice] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Invoice] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[InvoiceDetail] CHECK CONSTRAINT [FK_InvoiceDetail_Invoice]
GO
