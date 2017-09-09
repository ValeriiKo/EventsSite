CREATE TABLE [dbo].[Events]
(
	[EventId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NOT NULL, 
    [BeginDate] DATETIME NULL, 
    [Description] VARCHAR(MAX) NULL
)
