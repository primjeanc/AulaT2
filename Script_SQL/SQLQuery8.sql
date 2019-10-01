create database BaseSistemaLocacao -- criamos nossa base de dados
GO
use BaseSistemaLocacao -- indicamos que estamos utilizando ela para os comandos
-- logo a baixo
GO
/*Criação nossa primeira tabela do banco de dados*/
create table Usuarios
(    [Id]               INT         IDENTITY (1, 1) NOT NULL,
    [Nome]             NCHAR (100) NULL,
    [Login]            NCHAR (50)  NULL,
    [Senha]            NCHAR (50)  NULL,
    [Ativo]            BIT         DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT         DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT         DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME    DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME    DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
GO -- Aqui definimos que vamos criar mais tabelas, etc

create table Marcas
(    [Id]     INT        IDENTITY (1, 1) NOT NULL,
    [Codigo] INT        NULL,
    [Nome]   NCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC))
GO

create table Carros
(    [Id]               INT        IDENTITY (1, 1) NOT NULL,
    [Modelo]           NCHAR (50) NULL,
    [MarcaCodigo]      INT        NULL,
    [Placa]            NCHAR (7)  NULL,
    [Ano]              INT        NULL,
    [Ativo]            BIT        DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT        DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT        DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME   DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME   DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC))
	GO

create table Locacoes
(    [Id]               INT      IDENTITY (1, 1) NOT NULL,
    [UsuarioId]        INT      NULL,
    [CarroId]          INT      NULL,
    [Valor]            MONEY    NULL,
    [DataIncial]       DATETIME DEFAULT (getdate()) NULL,
    [DataDevolucao]    DATETIME DEFAULT (dateadd(day,(5),getdate())) NULL,
    [Ativo]            BIT      DEFAULT ((1)) NULL,
    [UsuarioCriacao]   INT      DEFAULT ((0)) NULL,
    [UsuarioAlteracao] INT      DEFAULT ((0)) NULL,
    [DataCriacao]      DATETIME DEFAULT (getdate()) NULL,
    [DataAlteracao]    DATETIME DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC))
GO
insert into Usuarios 
([Nome],[Login],[Senha]) values ('Administrador','admin','admin')
GO
insert into Marcas 
(Codigo,Nome) values (1, 'Volkswagen'),(2,'Chevrolet'),(3,'Hyundai'),(4,'Fiat')
GO
insert into Carros (Modelo, MarcaCodigo, Placa, Ano, Ativo) values 
('Fusca', 1, 'XGH0001', 1989, 1),
('HB20', 3, 'FAP2407', 2018, 1),
('Gol', 1, 'SOS9999', 2016, 1),
('Cruze', 2, 'POO1111', 2018, 1)
GO


select 
car.Modelo,
mar.Nome as 'Marca',
usu.Nome as 'UsuarioCriacao' 
from Carros car inner join Marcas mar on car.MarcaCodigo = mar.Codigo
				inner join Usuarios usu on car.UsuarioCriacao = usu.Id

