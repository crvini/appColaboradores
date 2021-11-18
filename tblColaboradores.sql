USE [PruebaC]
GO

/****** Object:  Table [dbo].[colaboradores]    Script Date: 17/11/2021 19:08:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[colaboradores](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[EstadoCivil] [nvarchar](20) NULL,
	[GradoA] [nvarchar](20) NULL,
	[Direccion] [nvarchar](100) NULL,
 CONSTRAINT [PK_colaboradores] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

