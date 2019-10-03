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

select fu.Nome as 'Funcionário', sa.valor as 'Salário', sa.DataCriacao as 'Pagamento' from Funcionarios fu
inner join Salarios sa on fu.Id = sa.Funcionario

insert into Funcionarios (Nome) values ('DarthVader')
GO
insert into Salarios (Funcionario, Valor, DataCriacao) values
(4,22500,'07/05/2019'),
(4,22500,'08/07/2019'),
(4,22550,'09/06/2019')
GO
/*convert date que retorna data ingles simples*/
select fu.Nome as 'Funcionário', sa.valor as 'Salário', convert(date,sa.DataCriacao) as 'Recebido em' from Funcionarios fu
inner join Salarios sa on fu.Id = sa.Funcionario
order by sa.Valor asc
/* ou convert varchar data ptbr*/
select fu.Nome as 'Funcionário', sa.valor as 'Salário', convert(varchar(12),sa.DataCriacao,103) as 'Recebido em' from Funcionarios fu
inner join Salarios sa on fu.Id = sa.Funcionario --se retirar o 103 volta pro formato Jun 5 2019
order by sa.Valor asc 

/*sum VALOR sem inner join*/
select Nome,
(select sum(Valor) from Salarios 
where Funcionario = Funcionarios.Id) from Funcionarios
/*sum VALOR com inner join*/
select fu.Nome, sum(sa.Valor) as 'Total nos 3 meses' from Funcionarios fu 
inner join Salarios sa on fu.Id = sa.Funcionario
group by fu.Nome
/*average VALOR com inner join*/
select fu.Nome, avg(sa.Valor) as 'Total nos 3 meses', count(sa.Valor) as ' Qtd pagamentos',
sum(sa.Valor)/count(sa.Valor) as 'Nova Média' from Funcionarios fu 
inner join Salarios sa on fu.Id = sa.Funcionario
group by fu.Nome 
order by sum(sa.Valor) desc
/*valores ENTRE um limite informado como perido de mes x a y ou IDs de tanto a tanto*/
select * from Salarios where Id between 3 and 8

select * from Salarios
where DataCriacao between '07/06/2019' and '08/07/2019'

/*retorna os 5 primeiros*/
select top 5 * from Salarios
--da de usar TOP 1 pra limitar resultado a uma unica linha quando acaba 'misteriosamente' saindo mais que 1 = XGH plus***


/*----------------------------------------------------------*/
select * from Funcionarios
/*update sem where!!!! loucura loucura, a ideia eh marcar todos os funcionarios com Ativo=1*/
update Funcionarios set Ativo =1
select * from Funcionarios
/*----------------------------------------------------------*/
/*para conferir um update ou delete podemos tentar listar o filtro informado antes de executar*/
select * from Funcionarios where Nome like '%er'
/*com filtro*/
update Funcionarios 
set DataSaida = '10/03/2019', Ativo = 0, DataAlteracao = getdate()
where Nome like 'Mun%' -- pega valores que contenham 'Mun'+ qlqr coisa,  %Mun pegaria qlqr coisa + Mun no final
-- %Wa% pegaria de ambos os lados como SkyWalker

select * from Funcionarios




