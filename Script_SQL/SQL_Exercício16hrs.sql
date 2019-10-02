--2.2 - Temos que inserir  para cada funcionário as folhas de pagamento dos 
--respectivos meses de trabalho deste ano 7,8,9  sabendo que os salarios sempre são pagos no 5 dia util de cada  mês
create database SistemaRH
GO
use SistemaRH
GO

create table Salarios
(
Id int primary key identity (1,1) not null,
Funcionario int,-- comparar com  funcionarios.Id
Valor money default 0,
Ativo bit default 1,
UsuarioCriacao int default 0,
UsuarioAlteracao int default 0,
DataCriacao datetime default getdate(),
DataAlteracao datetime default getdate()
)
Go
create table Funcionarios
(
Id int primary key identity (1,1) not null,
Nome nvarchar(40),
DataInicio datetime default getdate(),
DataSaida datetime default dateadd (month, 3,getdate()),
Ativo bit default 1,
UsuarioCriacao int default 0,
UsuarioAlteracao int default 0,
DataCriacao datetime default getdate(),
DataAlteracao datetime default getdate()
)
GO
/*2.1 criar 3 funcionarios*/
insert into Funcionarios (Nome) values ('SkyWalker'),('Yoda'),('Mun-Ha')
/*2.2  inserir 3 pagamentos(jul/ago/set) para cada*/
insert into Salarios (Funcionario, Valor, DataCriacao) values
(1,2500.50,'07/05/2019'),
(1,2500.50,'08/07/2019'),
(1,2550.50,'09/06/2019'),
(2,1900,'07/05/2019'),
(2,1900,'08/07/2019'),
(2,1950,'09/06/2019'),
(3,12500,'07/05/2019'),
(3,12500,'08/07/2019'),
(3,12500,'09/06/2019')







