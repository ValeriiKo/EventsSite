USE [Events]
GO

/****** Object: Table [dbo].[Users] Script Date: 09.09.2017 13:55:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users] (
    [UserId]      INT          IDENTITY (1, 1) NOT NULL,
    [UserName]    VARCHAR (50) NOT NULL,
    [Email]       VARCHAR (50) NULL,
    [Password]    VARCHAR (50) NOT NULL,
    [StatusAdmin] BIT          NOT NULL
);


