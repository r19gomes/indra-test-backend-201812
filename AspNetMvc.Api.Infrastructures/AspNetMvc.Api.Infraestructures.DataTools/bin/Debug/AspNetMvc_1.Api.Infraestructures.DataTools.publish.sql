﻿/*
Deployment script for DB_INTRA_BANK

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "DB_INTRA_BANK"
:setvar DefaultFilePrefix "DB_INTRA_BANK"
:setvar DefaultDataPath "C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\"
:setvar DefaultLogPath "C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Dropping [dbo].[FK_Agencias_BancoId_Bancos_BancoId]...';


GO
ALTER TABLE [dbo].[Agencias] DROP CONSTRAINT [FK_Agencias_BancoId_Bancos_BancoId];


GO
PRINT N'Starting rebuilding table [dbo].[Bancos]...';


GO
BEGIN TRANSACTION;

SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

SET XACT_ABORT ON;

CREATE TABLE [dbo].[tmp_ms_xx_Bancos] (
    [BancoId]              BIGINT         IDENTITY (1, 1) NOT NULL,
    [Codigo]               VARCHAR (15)   NOT NULL,
    [Nome]                 VARCHAR (200)  NOT NULL,
    [Apelido]              VARCHAR (50)   NOT NULL,
    [NumeroCnpj]           VARCHAR (15)   NULL,
    [WebSiteOficial]       VARCHAR (1000) NULL,
    [FlagStatus]           BIT            NOT NULL,
    [CadastroUsuarioId]    BIGINT         NOT NULL,
    [CadastroDataHora]     DATETIME2 (7)  NOT NULL,
    [AtualizacaoUsuarioId] BIGINT         NULL,
    [AtualizacaoDataHora]  DATETIME2 (7)  NULL,
    CONSTRAINT [tmp_ms_xx_constraint_PK_Bancos1] PRIMARY KEY CLUSTERED ([BancoId] ASC) ON [PRIMARY]
) ON [PRIMARY];

IF EXISTS (SELECT TOP 1 1 
           FROM   [dbo].[Bancos])
    BEGIN
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_Bancos] ON;
        INSERT INTO [dbo].[tmp_ms_xx_Bancos] ([BancoId], [Codigo], [Nome], [Apelido], [NumeroCnpj], [FlagStatus], [CadastroUsuarioId], [CadastroDataHora], [AtualizacaoUsuarioId], [AtualizacaoDataHora])
        SELECT   [BancoId],
                 [Codigo],
                 [Nome],
                 [Apelido],
                 [NumeroCnpj],
                 [FlagStatus],
                 [CadastroUsuarioId],
                 [CadastroDataHora],
                 [AtualizacaoUsuarioId],
                 [AtualizacaoDataHora]
        FROM     [dbo].[Bancos]
        ORDER BY [BancoId] ASC;
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_Bancos] OFF;
    END

DROP TABLE [dbo].[Bancos];

EXECUTE sp_rename N'[dbo].[tmp_ms_xx_Bancos]', N'Bancos';

EXECUTE sp_rename N'[dbo].[tmp_ms_xx_constraint_PK_Bancos1]', N'PK_Bancos', N'OBJECT';

COMMIT TRANSACTION;

SET TRANSACTION ISOLATION LEVEL READ COMMITTED;


GO
PRINT N'Creating [dbo].[FK_Agencias_BancoId_Bancos_BancoId]...';


GO
ALTER TABLE [dbo].[Agencias] WITH NOCHECK
    ADD CONSTRAINT [FK_Agencias_BancoId_Bancos_BancoId] FOREIGN KEY ([BancoId]) REFERENCES [dbo].[Bancos] ([BancoId]);


GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[Agencias] WITH CHECK CHECK CONSTRAINT [FK_Agencias_BancoId_Bancos_BancoId];


GO
PRINT N'Update complete.';


GO
