USE [UsedCarDashboard]
GO

/****** Object:  StoredProcedure [dbo].[AddUser]    Script Date: 2022-12-19 1:33:10 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[AddUser]
	@pLogin NVARCHAR(50), 
    @pPassword NVARCHAR(50), 
    @pFirstName NVARCHAR(40),
    @pLastName NVARCHAR(40) = NULL,
	@pEmpType NVARCHAR(40),
    @responseMessage NVARCHAR(250) OUTPUT
AS
BEGIN
    SET NOCOUNT ON
	DECLARE @salt UNIQUEIDENTIFIER=NEWID()
    BEGIN TRY

        INSERT INTO [dbo].[Users] (LoginName, PasswordHash, Salt, FirstName, LastName, EmpType)
        VALUES(@pLogin, HASHBYTES('SHA2_512', @pPassword+CAST(@salt AS NVARCHAR(36))), @salt, @pFirstName, @pLastName, @pEmpType)

        SET @responseMessage='New User Created'

    END TRY
    BEGIN CATCH
        SET @responseMessage=ERROR_MESSAGE() 
    END CATCH

END
GO


