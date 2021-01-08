CREATE DATABASE BlazorApp;

CREATE TABLE [dbo].[Pessoas] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Nome] VARCHAR (150) NOT NULL,
    [Peso] INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

