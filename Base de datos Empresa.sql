USE [Empresa]
GO
/****** Object:  Table [dbo].[empleado]    Script Date: 28/7/2020 4:18:03 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleado](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Cedula] [varchar](40) NULL,
	[Nombre] [varchar](30) NULL,
	[Apellido] [varchar](30) NULL,
	[Telefono] [varchar](30) NULL,
	[Email] [varchar](30) NULL,
	[Departamento] [varchar](30) NULL,
	[Cargo] [varchar](30) NULL,
	[Fecha_ingreso] [date] NULL,
	[Salario] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nominas]    Script Date: 28/7/2020 4:18:03 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nominas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Año] [int] NULL,
	[mes] [varchar](20) NULL,
	[total] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[empleado] ON 

INSERT [dbo].[empleado] ([Id], [Cedula], [Nombre], [Apellido], [Telefono], [Email], [Departamento], [Cargo], [Fecha_ingreso], [Salario]) VALUES (4, N'4654654', N'Noel', N'Ortiz', N'808-494-4641', N'noeldrum17@hotmail.com', N'IT', N'Developer', CAST(N'2020-02-17' AS Date), 1450)
INSERT [dbo].[empleado] ([Id], [Cedula], [Nombre], [Apellido], [Telefono], [Email], [Departamento], [Cargo], [Fecha_ingreso], [Salario]) VALUES (5, N'23432', N'Randy ', N'Benjamin', N'809-446-4845', N'randybenjamin@hotmail.com', N'IT', N'Project Leader', CAST(N'2020-10-04' AS Date), 20000)
SET IDENTITY_INSERT [dbo].[empleado] OFF
GO
SET IDENTITY_INSERT [dbo].[nominas] ON 

INSERT [dbo].[nominas] ([id], [Año], [mes], [total]) VALUES (4, 2020, N'2', NULL)
SET IDENTITY_INSERT [dbo].[nominas] OFF
GO
