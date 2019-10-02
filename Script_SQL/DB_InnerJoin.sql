create database InnerJoin
GO
use InnerJoin
GO

-- //////////////////////////////// comentado acima para n repetir
create table Clientes
(
Id int primary key identity (1,1) not null,
Nome nvarchar(50) not null,
Genero int not null default 1,
Idade int null,
Ativo bit default 1,
UsuarioCriacao int default 0,
UsuarioAlteracao int default 0,
DataCriacao datetime default getdate(),
DataAlteracao datetime default getdate()
)
create table Pedidos
(
Id int primary key identity (1,1) not null,
Numero nvarchar(10),
ClienteId int not null,--vai comparar com Id da tabela clientes
Valor money,-- qlqr coisa tira o (5,2) 5 antes da ',' 2 decimais depois
Ativo bit default 1,
UsuarioCriacao int default 0,
UsuarioAlteracao int default 0,
DataCriacao datetime default getdate(),
DataAlteracao datetime default getdate()
constraint Fk_Pedidos_To_Clientes
foreign key (ClienteId) references Clientes (Id) /*o constraint liga colunas de diferentes tabelas, semelhante a innerjoin*/
)
GO
/*----------------------------------------*/
insert into Clientes (Nome, Genero,Idade) values ('Salim',1,89)


insert into Pedidos (ClienteId, Numero, Valor) values (1,'N00000001', 379.46)
select*from Pedidos

select pe.Numero, cli.Nome as 'Nome', pe.Valor, pe.DataCriacao as 'Data' from Pedidos pe
inner join Clientes cli on cli.Id = pe.ClienteId

/*criar 3 clientes e 3 pedidos para os mesmos*/
insert into Clientes (Nome, Genero,Idade) values 
('Bruna',2,19),
('SkyWalker',2,55),
('GunBound',2,15)
insert into Pedidos (ClienteId, Numero, Valor) values 
(2,'N00000002', 199.99),
(4,'N00000003', 95.75),
(3,'N00000004', 679.25),
(2,'N00000005', 95.75),
(2,'N00000006', 52.10),
(2,'N00000007', 495.05),
(3,'N00000008', 333.20),
(4,'N00000009', 100.50),
(3,'N00000010', 122.20),
(3,'N00000011', 1050.10),
(4,'N00000012', 145.92),
(3,'N00000013', 211.30),
(4,'N00000014', 209.60),
(3,'N00000015', 170.18)

/*listar todos os pedidos, ordenados por nome*/
/*se usar SELECT pe.* from ao inves de informar as colunas que vc quer, listaria todas as colunas*/
select pe.Numero, cli.Nome as 'Nome', pe.Valor, pe.DataCriacao as 'Data' from Pedidos pe
inner join Clientes cli on cli.Id = pe.ClienteId 
--where Nome = 'Bruna' /*caso queira filtrar por nome por exemplo*/
order by cli.Nome asc

/*pedidos acumulados por cliente*/
select cli.Id, cli.Nome, sum (pe.Valor) as 'Total de pedidos'  from Pedidos pe
inner join Clientes cli on cli.Id = pe.ClienteId
group by cli.Id, cli.Nome --agrupa nomes e/ids iguais para conseguir usar o SUM e somar pedidos
--having sum(pe.Valor) >600 -- somente se total for maior q 600
order by cli.Nome--ordem por nome

/*usando iif 'if' retornando soma de pedidos maior q um valor x*/
select iif (sum (pe.Valor)>1000,'like a boss','mão de vaca') as 'Total de pedidos', cli.Id, cli.Nome, sum (pe.Valor) as 'Total'  from Pedidos pe
inner join Clientes cli on cli.Id = pe.ClienteId
group by cli.Id, cli.Nome --agrupa nomes e/ids iguais para conseguir usar o SUM e somar pedidos
--having sum(pe.Valor) >600 -- somente se total for maior q 600
order by cli.Nome--ordem por nome


