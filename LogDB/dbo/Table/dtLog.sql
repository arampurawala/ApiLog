CREATE TABLE [dbo].[dtLog]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Url] VARCHAR(100) NOT NULL, 
    [IpAddress] VARCHAR(21) NOT NULL, 
    [Date] DATETIME NOT NULL
)
