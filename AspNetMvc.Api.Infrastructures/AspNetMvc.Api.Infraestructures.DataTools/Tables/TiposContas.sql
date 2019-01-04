﻿CREATE TABLE [dbo].[TiposContas]
(
	[TipoContaId] INT IDENTITY(1,1) NOT NULL
,	[Nome] NCHAR(10) NULL
,	[FlagStatus] BIT NOT NULL
,	[CadastroUsuarioId] BIGINT NOT NULL
,	[CadastroDataHora] DATETIME2 NOT NULL
,	[AtualizacaoUsuarioId] BIGINT NULL
,	[AtualizacaoDataHora] DATETIME2 NULL
,	CONSTRAINT [PK_MovimentoManual] PRIMARY KEY CLUSTERED 
	(
		[TipoContaId] ASC
	)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO 