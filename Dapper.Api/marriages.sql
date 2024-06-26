USE [MarriageDB]
GO
/****** Object:  Table [dbo].[Marriages]    Script Date: 2024/5/13 下午 04:12:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marriages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[statistic_yyy] [nvarchar](50) NOT NULL,
	[according] [nvarchar](255) NOT NULL,
	[site_id] [nvarchar](255) NOT NULL,
	[marry_count] [int] NOT NULL,
	[marriage_type] [nvarchar](255) NOT NULL,
	[sex] [nvarchar](10) NOT NULL,
	[nation] [nvarchar](255) NOT NULL,
	[edu] [nvarchar](255) NOT NULL,
	[age] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
