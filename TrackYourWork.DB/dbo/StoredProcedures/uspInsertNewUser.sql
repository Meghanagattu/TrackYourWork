-- =============================================
-- Author:		Meghna
-- Description:	Insert new user
-- =============================================
CREATE PROCEDURE [dbo].[uspInsertNewUser] 
	@userName nvarchar(100),
	@password nvarchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    INSERT INTO [dbo].[tbUser]
	VALUES
	(@userName,@password)
END

GO