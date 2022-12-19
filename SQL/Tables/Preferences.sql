USE [UsedCarDashboard]
GO

/****** Object:  Table [dbo].[Preferences]    Script Date: 2022-12-19 1:33:03 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Preferences](
	[PrefID] [int] IDENTITY(1,1) NOT NULL,
	[BuyerID] [int] NOT NULL,
	[CarID] [int] NOT NULL,
 CONSTRAINT [PK_Preferences_PrefID] PRIMARY KEY CLUSTERED 
(
	[PrefID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Preferences]  WITH CHECK ADD  CONSTRAINT [FK_Preferences_BuyerID] FOREIGN KEY([BuyerID])
REFERENCES [dbo].[Buyer] ([BuyerID])
GO

ALTER TABLE [dbo].[Preferences] CHECK CONSTRAINT [FK_Preferences_BuyerID]
GO

ALTER TABLE [dbo].[Preferences]  WITH CHECK ADD  CONSTRAINT [FK_Preferences_CarID] FOREIGN KEY([CarID])
REFERENCES [dbo].[Car] ([CarID])
GO

ALTER TABLE [dbo].[Preferences] CHECK CONSTRAINT [FK_Preferences_CarID]
GO


