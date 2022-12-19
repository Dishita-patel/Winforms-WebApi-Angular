USE [UsedCarDashboard]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 2022-12-19 1:50:29 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[LoginName] [nvarchar](40) NOT NULL,
	[PasswordHash] [binary](64) NOT NULL,
	[FirstName] [nvarchar](40) NOT NULL,
	[LastName] [nvarchar](40) NULL,
	[EmpType] [nvarchar](40) NOT NULL,
	[Salt] [uniqueidentifier] NULL,
 CONSTRAINT [PK_User_UserID] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [chk_EmpType] CHECK  (([EmpType]='Sales' OR [EmpType]='Employee'))
GO

ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [chk_EmpType]
GO
