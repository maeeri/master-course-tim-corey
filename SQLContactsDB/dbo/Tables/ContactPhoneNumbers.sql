CREATE TABLE [dbo].[ContactPhoneNumbers]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[ContactId] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[Contacts]([Id]), 
	[PhoneId] INT NOT NULL FOREIGN KEY REFERENCES [dbo].[PhoneNumbers]([Id])
)
