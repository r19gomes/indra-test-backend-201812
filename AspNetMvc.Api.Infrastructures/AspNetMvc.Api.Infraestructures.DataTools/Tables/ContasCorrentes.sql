CREATE TABLE [dbo].[ContasCorrentes]
(
	[BancoId] BIGINT NOT NULL
,	[AgenciaId] BIGINT NOT NULL
,	[ContaCorrenteId] BIGINT IDENTITY(1,1) NOT NULL
,	[TipoContaId] INT NULL
,	[Numero] INT NULL
,	[Digito] SMALLINT NULL
,	[Titular] VARCHAR(250) NULL
,	[TitularCnpjCpf] VARCHAR(15) NULL
,	[TipoPessoaId] INT NULL
,	[Observacao] VARCHAR(MAX) NULL
,	[FlagStatus] BIT NOT NULL
,	[CadastroUsuarioId] BIGINT NOT NULL
,	[CadastroDataHora] DATETIME2 NOT NULL
,	[AtualizacaoUsuarioId] BIGINT NULL
,	[AtualizacaoDataHora] DATETIME2 NULL, 
    CONSTRAINT [PK_ContasCorrentes] PRIMARY KEY CLUSTERED 
	(
		[BancoId] ASC,
		[AgenciaId] ASC,
		[ContaCorrenteId] ASC
	)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO 

ALTER TABLE [dbo].[ContasCorrentes] ADD
CONSTRAINT [FK_ContasCorrentes_BancoId_AgenciaId_Agencias_BancoId_AgenciaId] FOREIGN KEY
(
	[BancoId],
	[AgenciaId]
) REFERENCES [dbo].[Agencias] (
	[BancoId],
	[AgenciaId]
) 
GO

ALTER TABLE [dbo].[ContasCorrentes] ADD
CONSTRAINT [FK_ContasCorrentes_TipoContaId_TiposContas] FOREIGN KEY
(
	[TipoContaId]
) REFERENCES [dbo].[TiposContas] (
	[TipoContaId]
) 
GO

ALTER TABLE [dbo].[ContasCorrentes] ADD
CONSTRAINT [FK_ContasCorrentes_TipoPessoaId_TiposPessoas] FOREIGN KEY
(
	[TipoPessoaId]
) REFERENCES [dbo].[TiposPessoas] (
	[TipoPessoaId]
) 
GO