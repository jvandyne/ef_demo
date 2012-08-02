﻿CREATE TABLE [dbo].[Employee] (
    [Id]        INT          IDENTITY (0, 1) NOT NULL,
    [FirstName] VARCHAR (25) NULL,
    [LastName]  VARCHAR (25) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);
