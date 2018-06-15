-- =============================================
-- Author:		Meghana
-- Create date: <Create Date,,>
-- Description:	To insert new ticket details in DB
-- =============================================
CREATE PROCEDURE [dbo].[uspInsertNewTicket] 
	-- Add the parameters for the stored procedure here
	@emailId nvarchar(100),
	@ticketDesc nvarchar(max),
	@ticketType nvarchar(15)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    INSERT INTO [dbo].[tbTickets]
	([TicketDesc],[CreatedBy],[CreatedOn],[TicketType])
	VALUES
	(@ticketDesc,@emailId,GETDATE(),@ticketType)
END

GO