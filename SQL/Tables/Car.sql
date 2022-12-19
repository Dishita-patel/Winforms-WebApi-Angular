USE [UsedCarDashboard]
GO

/****** Object:  Table [dbo].[Car]    Script Date: 2022-12-19 1:32:51 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Car](
	[CarID] [int] IDENTITY(1,1) NOT NULL,
	[Color] [nvarchar](40) NULL,
	[Make] [nvarchar](40) NOT NULL,
	[Model] [nvarchar](40) NOT NULL,
	[Year] [int] NOT NULL,
	[Mileage] [decimal](3, 1) NOT NULL,
	[Price] [decimal](15, 4) NOT NULL,
	[PreviousOwners] [int] NOT NULL,
 CONSTRAINT [PK_Car_CarID] PRIMARY KEY CLUSTERED 
(
	[CarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


