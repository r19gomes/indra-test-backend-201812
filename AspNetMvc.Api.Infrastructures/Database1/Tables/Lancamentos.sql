CREATE TABLE [dbo].[Lancamentos]
(
	[LancamentoId] BIGINT IDENTITY(1,1) NOT NULL
,	[BancoId] BIGINT NOT NULL
,	[AgenciaId] BIGINT NOT NULL
,	[ContaCorrenteId] BIGINT NOT NULL
,	[TipoLancamento] VARCHAR NOT NULL
,	[Titulo] VARCHAR(600) NULL
,	[Conteudo] VARCHAR(MAX) NULL
,	[FlagStatus] BIT NOT NULL
,	[LancamentoPaiId] BIGINT NULL
,	[CadastroUsuarioId] BIGINT NOT NULL
,	[CadastroDataHora] DATETIME2 NOT NULL
,	[AtualizacaoUsuarioId] BIGINT NULL
,	[AtualizacaoDataHora] DATETIME2 NULL
    CONSTRAINT [PK_Lancamentos] PRIMARY KEY CLUSTERED 
	(
		[LancamentoId] ASC
	)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO 

ALTER TABLE [dbo].[Lancamentos] ADD
CONSTRAINT [FK_Lancamentos_BancoId_AgenciaId_ContaCorrenteId_ContasCorrentes_BancoId_AgenciaId_ContaCorrenteId] FOREIGN KEY
(
	[BancoId]
,	[AgenciaId]
,	[ContaCorrenteId]
) REFERENCES [dbo].[ContasCorrentes] (
	[BancoId]
,	[AgenciaId]
,	[ContaCorrenteId]
) 
GO

ALTER TABLE [dbo].[Lancamentos] ADD
CONSTRAINT [FK_Lancamentos_LancamentoPaiId_Lancamentos_LancamentoId] FOREIGN KEY
(
	[LancamentoPaiId]
) REFERENCES [dbo].[Lancamentos] (
	[LancamentoId]
) 
GO
