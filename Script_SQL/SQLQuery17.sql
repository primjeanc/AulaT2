create table Carros(
Id int not null primary key identity(1,1),
Modelo nchar(50),
Marca nchar(50) not null,
Placa nchar(7),
Ano int,
Ativo bit default 1,
UsuarioCriacao int,
UsuarioAlteracao int,
DataCriacao datetime default getdate(),
DataAlteracao datetime default getdate())

create table Locacoes(
Id int not null primary key identity(1,1),
UsuarioId int not null,
CarroId int not null,
Valor money,
DataInicial datetime default getdate(),
DataDevolucao datetime,
Ativo bit default 1,
UsuarioCriacao int,
UsuarioAlteracao int,
DataCriacao datetime default getdate(),
DataAlteracao datetime default dateadd(day,5,getdate())
)