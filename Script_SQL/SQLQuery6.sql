--tenta criar tabela, caso de ja existir, nao cria mas n da erro.
if not exists (select * from sysobjects where name = 'Usuarios' and xtype = 'U')
create table Usuarios
(
Id INT primary key identity (1,1) NOT NULL,
Nome NCHAR (100) NOT NULL,
Login NCHAR (50)  NULL,
Senha NCHAR (50)  NULL,
Ativo BIT DEFAULT ((1)) NULL,
UsuarioCriacao INT DEFAULT ((0)) NULL,
UsuarioAlteracao INT DEFAULT ((0)) NULL,
DataCriacao DATETIME DEFAULT (getdate()) NULL,
DataAlteracao DATETIME DEFAULT (getdate()) NULL,
)
GO
if not exists (select * from sysobjects where name = 'Marcas' and xtype = 'U')
create table Marcas
(
Id INT primary key identity (1, 1) not null,
Codigo INT not null,
Nome NCHAR (20) not null,
)
GO

if not exists (select * from sysobjects where name = 'Locacoes' and xtype = 'U')
create table Locacoes
(
Id INT primary key identity (1, 1) NOT NULL,
UsuarioId INT,
CarroId INT,
Valor MONEY,
DataInicial DATETIME DEFAULT (getdate()) NULL,
DataDevolucao DATETIME DEFAULT (dateadd(day,(5),getdate())),
Ativo BIT DEFAULT ((1)) NULL,
UsuarioCriacao INT DEFAULT ((0)) NULL,
UsuarioAlteracao INT DEFAULT ((0)) NULL,
DataCriacao DATETIME DEFAULT (getdate()) NULL,
DataAlteracao DATETIME DEFAULT (getdate()) NULL,   
)
GO

if not exists (select * from sysobjects where name = 'Carros' and xtype = 'U')
create table Carros
(
Id int primary key identity(1,1) not null,
Modelo nchar(50) not null,
MarcaCodigo int,
Placa nchar(7) not null,
Ano int not null,
Ativo bit default ((1)),
UsuarioCriacao INT DEFAULT ((0)) NULL,
UsuarioAlteracao INT DEFAULT ((0)) NULL,
DataCriacao datetime default getdate(),
DataAlteracao datetime default getdate()
)
GO

insert into Carros (Modelo, MarcaCodigo, Placa, Ano, Ativo) values 
('Fusion', 2, 'XGH0001', 2019, 1),
('Civic', 4, 'FAP2407', 2000, 1),
('Fit', 4, 'SOS9999', 2016, 1),
('EcoSport', 2, 'POO1111', 2018, 1)
GO
insert into Usuarios (Nome, Login, Senha, Ativo) values
('Admin','Admin','Admin',1),
('Global','HBSIS','PROWAY',1)
GO
insert into Marcas (Codigo, Nome) values
(1,'Volkswagem'),(2, 'Ford'), (3,'Honda')
GO
insert into Locacoes (UsuarioId, CarroId,Valor,Ativo) values
(3,1,250,1),(3,2,300,1),(3,3,330,1)
GO

select c.Modelo, m.Nome as 'Marca', u.Nome as 'UsuarioCriacao', ua.Nome as 'UsuarioAlteracao' 
from Carros c inner join Marcas m on c.MarcaCodigo = m.Codigo 
			  inner join Usuarios u on c.UsuarioCriacao = u.Id
			  inner join Usuarios ua on c.UsuarioAlteracao = ua.Id
GO



