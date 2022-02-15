IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220106192023_Banco')
BEGIN
    CREATE TABLE [Candidato] (
        [Id_candidato] int NOT NULL IDENTITY,
        [Nome_candidato] nvarchar(50) NOT NULL,
        [Nascimento_candidato] datetime2 NOT NULL,
        [Estado_civil_candidato] nvarchar(20) NULL,
        [Nacionalidade_candidato] nvarchar(50) NULL,
        [Rne_candidato] nvarchar(50) NOT NULL,
        [Idioma_candidato] nvarchar(30) NULL,
        [Email_candidato] nvarchar(50) NULL,
        [Senha_candidato] nvarchar(20) NULL,
        [Cargo1_candidato] nvarchar(50) NULL,
        [Cargo2_candidato] nvarchar(50) NULL,
        [Cargo3_candidato] nvarchar(50) NULL,
        CONSTRAINT [PK_Candidato] PRIMARY KEY ([Id_candidato])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220106192023_Banco')
BEGIN
    CREATE TABLE [Empresa] (
        [Id_empresa] int NOT NULL IDENTITY,
        [Cod_vaga] int NOT NULL,
        [Nome_empresa] nvarchar(50) NOT NULL,
        [Cnpj_empresa] nvarchar(20) NOT NULL,
        [Cep_empresa] nvarchar(15) NULL,
        [Ramo_empresa] nvarchar(30) NULL,
        [Telefone_empresa] nvarchar(20) NULL,
        [Linkedin_empresa] nvarchar(50) NULL,
        CONSTRAINT [PK_Empresa] PRIMARY KEY ([Id_empresa])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220106192023_Banco')
BEGIN
    CREATE TABLE [Idioma] (
        [Id_idioma] int NOT NULL IDENTITY,
        [Nome_idioma] nvarchar(30) NULL,
        [Nivel_leitura_idioma] nvarchar(30) NULL,
        [Nivel_escrita_idioma] nvarchar(30) NULL,
        [Nivel_conversacao_idioma] nvarchar(30) NULL,
        CONSTRAINT [PK_Idioma] PRIMARY KEY ([Id_idioma])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220106192023_Banco')
BEGIN
    CREATE TABLE [Recrutador] (
        [Id_recrutador] int NOT NULL IDENTITY,
        [Nome_empresa] nvarchar(50) NULL,
        [Id_empresa] int NOT NULL,
        [Nome_recrutador] nvarchar(50) NULL,
        [Cargo_recrutador] nvarchar(50) NULL,
        [Departamento_recrutador] nvarchar(50) NULL,
        [Email_recrutador] nvarchar(50) NULL,
        [Tel_recrutador] nvarchar(20) NULL,
        [Contato2_recrutador] nvarchar(50) NULL,
        [Senha_recrutador] nvarchar(20) NULL,
        CONSTRAINT [PK_Recrutador] PRIMARY KEY ([Id_recrutador])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220106192023_Banco')
BEGIN
    CREATE TABLE [Vaga] (
        [Cod_vaga] int NOT NULL IDENTITY,
        [Id_empresa] int NOT NULL,
        [Cargo_vaga] nvarchar(50) NOT NULL,
        [Descricao_vaga] nvarchar(500) NOT NULL,
        [Salario_vaga] float NOT NULL,
        [Vaga_pcd] bit NOT NULL,
        [Nivel_instrucao_vaga] nvarchar(30) NULL,
        [Localidade_vaga] nvarchar(30) NULL,
        [Regime_contratacao_vaga] nvarchar(30) NULL,
        CONSTRAINT [PK_Vaga] PRIMARY KEY ([Cod_vaga])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220106192023_Banco')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220106192023_Banco', N'5.0.12');
END;
GO

COMMIT;
GO

