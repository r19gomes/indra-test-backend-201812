CREATE TABLE [dbo].[Agencias]
(
	[BancoId] BIGINT NOT NULL,
	[AgenciaId] BIGINT IDENTITY(1,1) NOT NULL
,	[Nome] VARCHAR(300) NOT NULL
,	[Numero] INT NOT NULL
,	[Digito] SMALLINT NOT NULL
,	[FlagStatus] BIT NOT NULL
,	[CadastroUsuarioId] BIGINT NOT NULL
,	[CadastroDataHora] DATETIME2 NOT NULL
,	[AtualizacaoUsuarioId] BIGINT NULL
,	[AtualizacaoDataHora] DATETIME2 NULL
,	CONSTRAINT [PK_Agencias] PRIMARY KEY CLUSTERED 
	(
		[BancoId] ASC,
		[AgenciaId] ASC
	)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO 

ALTER TABLE [dbo].[Agencias] ADD
CONSTRAINT [FK_Agencias_BancoId_Bancos_BancoId] FOREIGN KEY
(
	[BancoId]
) REFERENCES [dbo].[Bancos] (
	[BancoId]
) 
GO