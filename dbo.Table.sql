CREATE TABLE [dbo].[CustomerAccount]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [name] NVARCHAR(150) NOT NULL, 
    [phone] NVARCHAR(25) NOT NULL, 
    [email] NVARCHAR(50) NOT NULL, 
    [accountNumber] NCHAR(15) NOT NULL, 
    [accountBalance] INT NOT NULL 
)
