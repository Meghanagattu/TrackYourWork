CREATE VIEW [dbo].[vwGetTicketList]
AS
SELECT        dbo.tbTickets.TicketId, dbo.tbTickets.TicketDesc, dbo.tbTickets.Status, dbo.tbTickets.IsActive, dbo.tbUser.UserName As AssignedTo
FROM            dbo.tbTickets INNER JOIN
                         dbo.tbUser ON dbo.tbTickets.AssignedTo = dbo.tbUser.Id



GO