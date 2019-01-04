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
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ANSI_NULLS ON,
                ANSI_PADDING ON,
                ANSI_WARNINGS ON,
                ARITHABORT ON,
                CONCAT_NULL_YIELDS_NULL ON,
                QUOTED_IDENTIFIER ON,
                ANSI_NULL_DEFAULT ON,
                CURSOR_DEFAULT LOCAL,
                RECOVERY FULL 
            WITH ROLLBACK IMMEDIATE;
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CLOSE OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET READ_COMMITTED_SNAPSHOT OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET PAGE_VERIFY NONE,
                DISABLE_BROKER 
            WITH ROLLBACK IMMEDIATE;
    END


GO
ALTER DATABASE [$(DatabaseName)]
    SET TARGET_RECOVERY_TIME = 0 SECONDS 
    WITH ROLLBACK IMMEDIATE;


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE (CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 367)) 
            WITH ROLLBACK IMMEDIATE;
    END


GO
PRINT N'Rename refactoring operation with key f8848d73-eb62-4117-b4a7-fa19e2612758 is skipped, element [dbo].[Bancos].[Id] (SqlSimpleColumn) will not be renamed to BancoId';


GO
PRINT N'Rename refactoring operation with key 66d7da06-1ec0-4fec-9197-78a1806fbe45 is skipped, element [dbo].[Agencias].[Id] (SqlSimpleColumn) will not be renamed to AgenciaId';


GO
PRINT N'Rename refactoring operation with key 2418abab-efaf-4d96-a65c-e6b9802f1859 is skipped, element [dbo].[TiposContas].[Id] (SqlSimpleColumn) will not be renamed to TipoContaId';


GO
PRINT N'Rename refactoring operation with key 46539239-fa1a-43ba-a948-51b5d31c4ba7 is skipped, element [dbo].[TiposPessoas].[Id] (SqlSimpleColumn) will not be renamed to TipoPessoaId';


GO
PRINT N'Rename refactoring operation with key e4b84fab-40c7-47dd-907a-d0f39831033d is skipped, element [dbo].[ContasCorrentes].[Id] (SqlSimpleColumn) will not be renamed to BancoId';


GO
PRINT N'Rename refactoring operation with key 70e09a35-5e2f-40a3-bba6-2b0d36e3a1bd is skipped, element [dbo].[Lancamentos].[Id] (SqlSimpleColumn) will not be renamed to LancamentoId';


GO
PRINT N'Creating [dbo].[Agencias]...';


GO
CREATE TABLE [dbo].[Agencias] (
    [BancoId]              BIGINT        NOT NULL,
    [AgenciaId]            BIGINT        IDENTITY (1, 1) NOT NULL,
    [Nome]                 VARCHAR (300) NOT NULL,
    [Numero]               INT           NOT NULL,
    [Digito]               SMALLINT      NOT NULL,
    [FlagStatus]           BIT           NOT NULL,
    [CadastroUsuarioId]    BIGINT        NOT NULL,
    [CadastroDataHora]     DATETIME2 (7) NOT NULL,
    [AtualizacaoUsuarioId] BIGINT        NULL,
    [AtualizacaoDataHora]  DATETIME2 (7) NULL,
    CONSTRAINT [PK_Agencias] PRIMARY KEY CLUSTERED ([BancoId] ASC, [AgenciaId] ASC) ON [PRIMARY]
) ON [PRIMARY];


GO
PRINT N'Creating [dbo].[Bancos]...';


GO
CREATE TABLE [dbo].[Bancos] (
    [BancoId]              BIGINT        IDENTITY (1, 1) NOT NULL,
    [Codigo]               VARCHAR (15)  NOT NULL,
    [Nome]                 VARCHAR (200) NOT NULL,
    [Apelido]              VARCHAR (50)  NOT NULL,
    [NumeroCnpj]           VARCHAR (15)  NULL,
    [FlagStatus]           BIT           NOT NULL,
    [CadastroUsuarioId]    BIGINT        NOT NULL,
    [CadastroDataHora]     DATETIME2 (7) NOT NULL,
    [AtualizacaoUsuarioId] BIGINT        NULL,
    [AtualizacaoDataHora]  DATETIME2 (7) NULL,
    CONSTRAINT [PK_Bancos] PRIMARY KEY CLUSTERED ([BancoId] ASC) ON [PRIMARY]
) ON [PRIMARY];


GO
PRINT N'Creating [dbo].[ContasCorrentes]...';


GO
CREATE TABLE [dbo].[ContasCorrentes] (
    [BancoId]              BIGINT        NOT NULL,
    [AgenciaId]            BIGINT        NOT NULL,
    [ContaCorrenteId]      BIGINT        IDENTITY (1, 1) NOT NULL,
    [TipoContaId]          INT           NULL,
    [Numero]               INT           NULL,
    [Digito]               SMALLINT      NULL,
    [Titular]              VARCHAR (250) NULL,
    [TitularCnpjCpf]       VARCHAR (15)  NULL,
    [TipoPessoaId]         INT           NULL,
    [Observacao]           VARCHAR (MAX) NULL,
    [FlagStatus]           BIT           NOT NULL,
    [CadastroUsuarioId]    BIGINT        NOT NULL,
    [CadastroDataHora]     DATETIME2 (7) NOT NULL,
    [AtualizacaoUsuarioId] BIGINT        NULL,
    [AtualizacaoDataHora]  DATETIME2 (7) NULL,
    CONSTRAINT [PK_ContasCorrentes] PRIMARY KEY CLUSTERED ([BancoId] ASC, [AgenciaId] ASC, [ContaCorrenteId] ASC) ON [PRIMARY]
) ON [PRIMARY];


GO
PRINT N'Creating [dbo].[Lancamentos]...';


GO
CREATE TABLE [dbo].[Lancamentos] (
    [LancamentoId]         BIGINT        IDENTITY (1, 1) NOT NULL,
    [BancoId]              BIGINT        NOT NULL,
    [AgenciaId]            BIGINT        NOT NULL,
    [ContaCorrenteId]      BIGINT        NOT NULL,
    [TipoLancamento]       VARCHAR (1)   NOT NULL,
    [Titulo]               VARCHAR (600) NULL,
    [Conteudo]             VARCHAR (MAX) NULL,
    [FlagStatus]           BIT           NOT NULL,
    [LancamentoPaiId]      BIGINT        NULL,
    [CadastroUsuarioId]    BIGINT        NOT NULL,
    [CadastroDataHora]     DATETIME2 (7) NOT NULL,
    [AtualizacaoUsuarioId] BIGINT        NULL,
    [AtualizacaoDataHora]  DATETIME2 (7) NULL,
    CONSTRAINT [PK_Lancamentos] PRIMARY KEY CLUSTERED ([LancamentoId] ASC) ON [PRIMARY]
) ON [PRIMARY];


GO
PRINT N'Creating [dbo].[TiposContas]...';


GO
CREATE TABLE [dbo].[TiposContas] (
    [TipoContaId]          INT           IDENTITY (1, 1) NOT NULL,
    [Nome]                 NCHAR (10)    NULL,
    [FlagStatus]           BIT           NOT NULL,
    [CadastroUsuarioId]    BIGINT        NOT NULL,
    [CadastroDataHora]     DATETIME2 (7) NOT NULL,
    [AtualizacaoUsuarioId] BIGINT        NULL,
    [AtualizacaoDataHora]  DATETIME2 (7) NULL,
    CONSTRAINT [PK_MovimentoManual] PRIMARY KEY CLUSTERED ([TipoContaId] ASC) ON [PRIMARY]
) ON [PRIMARY];


GO
PRINT N'Creating [dbo].[TiposPessoas]...';


GO
CREATE TABLE [dbo].[TiposPessoas] (
    [TipoPessoaId]         INT           IDENTITY (1, 1) NOT NULL,
    [Nome]                 VARCHAR (50)  NOT NULL,
    [Apelido]              VARCHAR (20)  NOT NULL,
    [Sigla]                VARCHAR (3)   NULL,
    [FlagStatus]           BIT           NOT NULL,
    [CadastroUsuarioId]    BIGINT        NOT NULL,
    [CadastroDataHora]     DATETIME2 (7) NOT NULL,
    [AtualizacaoUsuarioId] BIGINT        NULL,
    [AtualizacaoDataHora]  DATETIME2 (7) NULL,
    CONSTRAINT [PK_TiposPessoas] PRIMARY KEY CLUSTERED ([TipoPessoaId] ASC) ON [PRIMARY]
) ON [PRIMARY];


GO
PRINT N'Creating [dbo].[FK_Agencias_BancoId_Bancos_BancoId]...';


GO
ALTER TABLE [dbo].[Agencias] WITH NOCHECK
    ADD CONSTRAINT [FK_Agencias_BancoId_Bancos_BancoId] FOREIGN KEY ([BancoId]) REFERENCES [dbo].[Bancos] ([BancoId]);


GO
PRINT N'Creating [dbo].[FK_ContasCorrentes_BancoId_AgenciaId_Agencias_BancoId_AgenciaId]...';


GO
ALTER TABLE [dbo].[ContasCorrentes] WITH NOCHECK
    ADD CONSTRAINT [FK_ContasCorrentes_BancoId_AgenciaId_Agencias_BancoId_AgenciaId] FOREIGN KEY ([BancoId], [AgenciaId]) REFERENCES [dbo].[Agencias] ([BancoId], [AgenciaId]);


GO
PRINT N'Creating [dbo].[FK_ContasCorrentes_TipoContaId_TiposContas]...';


GO
ALTER TABLE [dbo].[ContasCorrentes] WITH NOCHECK
    ADD CONSTRAINT [FK_ContasCorrentes_TipoContaId_TiposContas] FOREIGN KEY ([TipoContaId]) REFERENCES [dbo].[TiposContas] ([TipoContaId]);


GO
PRINT N'Creating [dbo].[FK_ContasCorrentes_TipoPessoaId_TiposPessoas]...';


GO
ALTER TABLE [dbo].[ContasCorrentes] WITH NOCHECK
    ADD CONSTRAINT [FK_ContasCorrentes_TipoPessoaId_TiposPessoas] FOREIGN KEY ([TipoPessoaId]) REFERENCES [dbo].[TiposPessoas] ([TipoPessoaId]);


GO
PRINT N'Creating [dbo].[FK_Lancamentos_BancoId_AgenciaId_ContaCorrenteId_ContasCorrentes_BancoId_AgenciaId_ContaCorrenteId]...';


GO
ALTER TABLE [dbo].[Lancamentos] WITH NOCHECK
    ADD CONSTRAINT [FK_Lancamentos_BancoId_AgenciaId_ContaCorrenteId_ContasCorrentes_BancoId_AgenciaId_ContaCorrenteId] FOREIGN KEY ([BancoId], [AgenciaId], [ContaCorrenteId]) REFERENCES [dbo].[ContasCorrentes] ([BancoId], [AgenciaId], [ContaCorrenteId]);


GO
PRINT N'Creating [dbo].[FK_Lancamentos_LancamentoPaiId_Lancamentos_LancamentoId]...';


GO
ALTER TABLE [dbo].[Lancamentos] WITH NOCHECK
    ADD CONSTRAINT [FK_Lancamentos_LancamentoPaiId_Lancamentos_LancamentoId] FOREIGN KEY ([LancamentoPaiId]) REFERENCES [dbo].[Lancamentos] ([LancamentoId]);


GO
-- Refactoring step to update target server with deployed transaction logs

IF OBJECT_ID(N'dbo.__RefactorLog') IS NULL
BEGIN
    CREATE TABLE [dbo].[__RefactorLog] (OperationKey UNIQUEIDENTIFIER NOT NULL PRIMARY KEY)
    EXEC sp_addextendedproperty N'microsoft_database_tools_support', N'refactoring log', N'schema', N'dbo', N'table', N'__RefactorLog'
END
GO
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'f8848d73-eb62-4117-b4a7-fa19e2612758')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('f8848d73-eb62-4117-b4a7-fa19e2612758')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '66d7da06-1ec0-4fec-9197-78a1806fbe45')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('66d7da06-1ec0-4fec-9197-78a1806fbe45')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '2418abab-efaf-4d96-a65c-e6b9802f1859')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('2418abab-efaf-4d96-a65c-e6b9802f1859')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '46539239-fa1a-43ba-a948-51b5d31c4ba7')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('46539239-fa1a-43ba-a948-51b5d31c4ba7')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = 'e4b84fab-40c7-47dd-907a-d0f39831033d')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('e4b84fab-40c7-47dd-907a-d0f39831033d')
IF NOT EXISTS (SELECT OperationKey FROM [dbo].[__RefactorLog] WHERE OperationKey = '70e09a35-5e2f-40a3-bba6-2b0d36e3a1bd')
INSERT INTO [dbo].[__RefactorLog] (OperationKey) values ('70e09a35-5e2f-40a3-bba6-2b0d36e3a1bd')

GO

GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[Agencias] WITH CHECK CHECK CONSTRAINT [FK_Agencias_BancoId_Bancos_BancoId];

ALTER TABLE [dbo].[ContasCorrentes] WITH CHECK CHECK CONSTRAINT [FK_ContasCorrentes_BancoId_AgenciaId_Agencias_BancoId_AgenciaId];

ALTER TABLE [dbo].[ContasCorrentes] WITH CHECK CHECK CONSTRAINT [FK_ContasCorrentes_TipoContaId_TiposContas];

ALTER TABLE [dbo].[ContasCorrentes] WITH CHECK CHECK CONSTRAINT [FK_ContasCorrentes_TipoPessoaId_TiposPessoas];

ALTER TABLE [dbo].[Lancamentos] WITH CHECK CHECK CONSTRAINT [FK_Lancamentos_BancoId_AgenciaId_ContaCorrenteId_ContasCorrentes_BancoId_AgenciaId_ContaCorrenteId];

ALTER TABLE [dbo].[Lancamentos] WITH CHECK CHECK CONSTRAINT [FK_Lancamentos_LancamentoPaiId_Lancamentos_LancamentoId];


GO
PRINT N'Update complete.';


GO