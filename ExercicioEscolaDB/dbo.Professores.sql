USE [SistemaEscolar]
GO

/****** Object: Table [dbo].[Professores] Script Date: 19/07/2019 17:00:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Professores] (
    [Id]    INT          IDENTITY (1, 1) NOT NULL,
    [Nome]  VARCHAR (50) NOT NULL,
    [Idade] INT          NOT NULL,
    [Ativo] BIT          NOT NULL
);


