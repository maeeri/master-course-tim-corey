CREATE TABLE [dbo].[ContactEmails]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ContactId] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[Contacts]([Id]), 
    [EmailId] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[EmailAddresses]([Id])
)
