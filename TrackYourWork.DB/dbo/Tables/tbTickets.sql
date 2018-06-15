CREATE TABLE [dbo].[tbTickets](
	[TicketId] [int] IDENTITY(1,1) NOT NULL,
	[TicketDesc] [nvarchar](max) NULL,
	[CreatedBy] [nvarchar](100) NULL,
	[CreatedOn] [datetime] NULL,
	[Status] [varchar](20) NULL,
	[IsActive] [bit] NULL DEFAULT ((1)),
	[AssignedTo] [int] NULL DEFAULT ((1)),
	[TicketType] [nvarchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[TicketId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

ALTER TABLE [dbo].[tbTickets]  WITH CHECK ADD  CONSTRAINT [FK_tbTickets_tbUser_UserID] FOREIGN KEY([AssignedTo])
REFERENCES [dbo].[tbUser] ([Id])
GO

ALTER TABLE [dbo].[tbTickets] CHECK CONSTRAINT [FK_tbTickets_tbUser_UserID]
GO


