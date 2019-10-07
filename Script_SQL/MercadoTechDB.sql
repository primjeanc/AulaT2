create database MercadoTechDB
go
use MercadoTechDB
go


create table Funcionarios(
Id int primary key identity(1,1) not null,
Nome nvarchar(40),
Ativo bit default 1,
UsuarioCriacao int default 0,
UsuarioAlteracao int default 0,
DataCriacao datetime default getdate(),
DataAlteracao datetime default getdate()
)
create table Produtos(
Id int primary key identity(1,1) not null,
Nome nvarchar(40),
Valor money default 0,
Ativo bit default 1,
UsuarioCriacao int default 0,
UsuarioAlteracao int default 0,
DataCriacao datetime default getdate(),
DataAlteracao datetime default getdate()
)
create table Pedidos(
Id int primary key identity(1,1) not null,
FuncionarioId int,
ProdutoId int,
Quantidade int default 0,
Ativo bit default 1,
UsuarioCriacao int default 0,
UsuarioAlteracao int default 0,
DataCriacao datetime default getdate(),
DataAlteracao datetime default getdate()
)
--2.2  - Agora devemos inseir 2 funcionarios diferentes
insert into Funcionarios (Nome) values ('Jean'),('Maria')
--	2.3  - Agora devemos cadastrar 5 produtos ambev com seus respectivos valores
insert into Produtos (Nome, Valor) values 
('Budweiser Lata c/12',9.55),
('Guaraná 2l c/6',11.99),
('Pepsi 2l c/6',14.25),
('Original 600 c/12',23.90),
('Corona LN c/24',52.20)
--	2.4  - Vamos realizar a felicidade dos funcionarios e realizar 3 pedidos, sendo 2 para o primeiro funcionario e 1 para o segundo
--	lembrando que cada pedido deve contem no minimo 2 itens e maximo de 5
insert into Pedidos (FuncionarioId, ProdutoId, Quantidade) values
(1,1,3),(2,3,4),(1,5,2)
--	2.5  - Vamos Listar em uma seleção de nossos funcionarios por ordem alfabetica
select Id, Nome from Funcionarios order by Nome asc
--	2.6  - Vamos listar em uma seleção de nossos produtos do mais caro para o mais barato
select Id, Nome, Valor from Produtos order by Valor desc
--	2.7  - Vamos listar em uma selação de nossos pedidos por funcionario trazendo o nome do funcionario
select pe.Id, fu.Nome, (pro.Valor*pe.Quantidade) as 'Valor Total' from Pedidos pe
inner join Funcionarios fu on pe.FuncionarioId = fu.Id
inner join Produtos pro on pe.ProdutoId = pro.Id
--	2.8  - Vamos listar em uma seleção de nossos pedidos agrupando por funcionario os pedidos e somando sua respectiva quantidade de itens
select fu.Nome, sum(pe.Quantidade) as 'Total de Itens' from Pedidos pe
inner join Funcionarios fu on pe.FuncionarioId = fu.Id
inner join Produtos pro on pe.ProdutoId = pro.Id
group by fu.Nome
--	2.9  - Vamos listar em uma seleção de nossos pedidos agrupando por funcionario os pedidos e somando seu valor total
--	lembrando que o valor total e a a "quantidade * valor"
select fu.Nome, sum(pro.Valor*pe.Quantidade) as 'Valor Total' from Pedidos pe
inner join Funcionarios fu on pe.FuncionarioId = fu.Id
inner join Produtos pro on pe.ProdutoId = pro.Id
group by fu.Nome
--	2.10 - Vamos retornar em uma seleção nosso produto mais pedido dentro de nossa base de dados
--select pro.* from Produtos pro inner join Pedidos pe on pe.ProdutoId=pro.Id --lista os produtos inseridos em pedidos
select top 1 pro.Nome, sum(pe.Quantidade) as 'Itens' from Pedidos pe
inner join Funcionarios fu on pe.FuncionarioId = fu.Id
inner join Produtos pro on pe.ProdutoId = pro.Id
group by pro.Nome 
order by sum(pe.Quantidade) desc
--	2.11 - Vamos retornar em uma seleção o produto que gerou a maior receita dentro de nossa base de dados 
select top 1 pro.Nome, sum(pe.Quantidade*pro.Valor) as 'Maior receita' from Pedidos pe
inner join Produtos pro on pe.ProdutoId = pro.Id
group by pro.Nome 
order by sum(pe.Quantidade*pro.Valor) desc
--	2.12 - Vamos retornar em uma seleção para o primeiro funcionario os produtos que ele não comprou de nosso mercado
select pro.Nome as 'Produtos não comprados pelo Jean(ID 1):' from Produtos pro 
where pro.Id not in (select pe.ProdutoId from Pedidos pe 
/* na linha a cima o 'WHERE pro.Id not in' pega os IDs dos produtos que nao estao nos pedidos
pedidos pe.ProdutoId retorna tudo q n foi listado comparando as tabelas (daria muito trabalho)*/
inner join Funcionarios fu on pe.FuncionarioId = fu.Id 
inner join Produtos pro on pe.ProdutoId = pro.Id
where fu.Id = 1 )
/* SELECT A.* FROM A WHERE ID NOT IN(SELECT ID FROM B)*/ --codigo base para NOT IN
--***********************************************************
/*Outra forma de resolver seria com left join que retornaria produtos nunca solicitados por ninguem,
seria complicado filtrar para cada funcionario*/
--select * from Produtos pro
--left join Pedidos pe on pro.Id = pe.ProdutoId where pe.produtoId is null
--***********************************************************

--	2.13 - Vamos retornar em uma seleção os produtos ordenados pela ordem do mais comprado para o menos comprado
-- no caso ele queria repeticao do item em pedidos e nao qual mais vendeu por isso COUNT e nao SUM
select pro.Nome, count(pe.Quantidade) as 'Quantidade' from Pedidos pe
inner join Funcionarios fu on pe.FuncionarioId = fu.Id
inner join Produtos pro on pe.ProdutoId = pro.Id
group by pro.Nome 
order by count(pe.Quantidade) desc
