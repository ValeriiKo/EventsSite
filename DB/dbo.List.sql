USE [Events]
GO

/****** Object: Table [dbo].[List] Script Date: 09.09.2017 13:54:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[List] (
    [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [EventId] INT NOT NULL, 
    [UserId] INT NOT NULL, 
    CONSTRAINT [FK_List_ToEvent] FOREIGN KEY ([EventId]) REFERENCES [Events]([EventId]), 
    CONSTRAINT [FK_List_User] FOREIGN KEY ([UserId]) REFERENCES [Users]([UserId])
);


