select top 4* from Usuarios
select top 2* from Vendas
select top 2* from Carros 
select top 2* from Marcas

/*Realizar um update das informações que contem usuario de criação 0 para o Id do usuario Felipe*/
update Marcas set UsuInc = 1 select * from Marcas where UsuInc = 0
--Trazer somente as marcas que Felipe cadastrou
select ma.Id, ma.Nome, us.Usuario from Marcas ma
inner join Usuarios us on us.Id = ma.UsuInc where us.Id =1
--Trazer somente as marcas que Giomar cadastrou
select ma.Id, ma.Nome, us.Usuario from Marcas ma
inner join Usuarios us on us.Id = ma.UsuInc where us.Id =2

/*Trazer somente a quantidade de marcas que Felipe cadastrou do maior para menor*/
select ma.Id, ma.Nome, us.Usuario from Marcas ma
inner join Usuarios us on us.Id = ma.UsuInc where us.Id =1
order by ma.Nome desc

/*Trazer somente a quantidade de marcas que Giomar cadastrou do menor para maior*/
select ma.Id, ma.Nome, us.Usuario from Marcas ma
inner join Usuarios us on us.Id = ma.UsuInc where us.Id =2
order by ma.Nome asc

/*Trazer somente a quantidade de marcas que Felipe e Giomar cadastraram */
select us.Usuario, count(us.Usuario) as 'Marcas' from Marcas ma
inner join Usuarios us on us.Id = ma.UsuInc 
group by us.Usuario
/*Trazer somente os carros que Felipe cadastrou*/
select us.Usuario, count(us.Usuario) from Carros ca
inner join Usuarios us on us.Id = ca.UsuInc where us.Id =1
group by us.Usuario
/*Trazer somente os carros que Giomar cadastrou*/
select us.Usuario, count(us.Usuario) from Carros ca
inner join Usuarios us on us.Id = ca.UsuInc where us.Id =2
group by us.Usuario

/*Trazer somente a quantidade de carros que Felipe cadastrou maior para menor*/
select us.Usuario, count(us.Usuario) from Carros ca
inner join Usuarios us on us.Id = ca.UsuInc where us.Id =1
group by us.Usuario order by us.Usuario desc
/*Trazer somente a quantidade de carros que Giomar cadastrou menor para maior*/
select us.Usuario, count(us.Usuario) from Carros ca
inner join Usuarios us on us.Id = ca.UsuInc where us.Id =1
group by us.Usuario order by us.Usuario asc

/*Trazer somente a quantidade de carros que Felipe e Giomar cadastraram */
select us.Usuario, count(us.Usuario) from Carros ca
inner join Usuarios us on us.Id = ca.UsuInc 
group by us.Usuario

/*Trazer somente os carros das marcas que Felipe cadastrou*/
select us.Usuario, ca.Modelo, ma.Nome from Carros ca
inner join Usuarios us on us.Id = ca.UsuInc
inner join Marcas ma on ma.Id = ca.Marca where us.Id =1 and ma.UsuInc =1


/*Trazer somente os carros das marcas que Giomar cadastrou*/
select us.Usuario, ca.Modelo, ma.Nome from Carros ca
inner join Usuarios us on us.Id = ca.UsuInc
inner join Marcas ma on ma.Id = ca.Marca where us.Id =2 and ma.UsuInc =2

/*Trazer somente a quantidade de carros das marcas que Felipe cadastrou maior para menor*/
select us.Usuario, ca.Modelo, ma.Nome from Carros ca
inner join Usuarios us on us.Id = ca.UsuInc
inner join Marcas ma on ma.Id = ca.Marca where us.Id =1 and ma.UsuInc =1
order by ca.Modelo desc

/*Trazer somente a quantidade de carros das marcas que Giomar cadastrou menor para maior*/
select us.Usuario, ca.Modelo, ma.Nome from Carros ca
inner join Usuarios us on us.Id = ca.UsuInc
inner join Marcas ma on ma.Id = ca.Marca where us.Id =2 and ma.UsuInc =2
order by ca.Modelo asc

--Trazer o valor total de vendas 2019 isolado
select sum(Valor) as 'Total de Vendas 2019' from Vendas where DatInc like '%2019%'

--Trazer a quantidade total de vendas 2019 isolado
select count(Valor) as 'Quantidade de Vendas 2019' from Vendas where DatInc like '%2019%'

--Trazer o valor total de vendas em cada ano e ordenar do maior para o menor
select sum(Valor) as 'Total de Vendas', year(DatInc) as 'Ano' from Vendas 
where year (DatInc) like '%2018%' or year (DatInc) like '%2019%' or year (DatInc) like '%2020%'
group by year( DatInc) 
order by sum(Valor) desc

--Trazer a quantidade de vendas em cada ano e ordenar do maior para o menor
select count(Valor) as 'Total de Vendas', year(DatInc) as 'Ano' from Vendas 
where year (DatInc) like '%2018%' or year (DatInc) like '%2019%' or year (DatInc) like '%2020%'
group by year( DatInc) 
order by sum(Valor) desc

--Trazer o mês de cada ano que retornou a maior quantidade de vendas  --*****************************************CORRIGIR
--		- Tradução "Retornar agrupado por mês e ordenar do maior para menor"
--TOP 3 xing ling
--select top 3 count(Valor) as 'Total de Vendas', month(DatInc) as 'mês' , year(DatInc) as 'Ano' from Vendas 
--where year (DatInc) like '%2018%'  or year (DatInc) like '%2019%' or year (DatInc) like '%2020%'
--group by month( DatInc), year(DatInc)
--order by (count(Valor)) desc 

select sum(Valor) as 'Total de Vendas', year(DatInc) as 'Ano' from Vendas --*************************************CORRIGIR
--where year (DatInc) like '%2018%' or year (DatInc) like '%2019%' or year (DatInc) like '%2020%'
group by year( DatInc) 
order by sum(Valor) desc

select top 1
(select top 1 Month(DatInc)	from Vendas	where YEAR(DatInc) = '2018'	group by MONTH(DatInc) order by sum(Valor) desc) as '2018',
(select top 1 Month(DatInc)	from Vendas	where YEAR(DatInc) = '2019'	group by MONTH(DatInc) order by sum(Valor) desc) as '2019',
(select top 1 Month(DatInc)	from Vendas	where YEAR(DatInc) = '2020'	group by MONTH(DatInc) order by sum(Valor) desc) as '2020'
from Vendas

		
--Trazer o mês de cada ano que retornou o maior valor de vendas
--		- Tradução "Retornar agrupado por mês e ordenar do maior para menor"
select max(Valor) as 'Total de Vendas', year(DatInc) as 'Ano', month(DatInc) from Vendas 
group by year( DatInc) 
order by max(Valor) desc

--Trazer o valor total de vendas que Felipe realizou
select sum(ve.Valor) as 'Total de Vendas', us.Usuario from Vendas ve 
inner join Usuarios us on us.Id = ve.UsuInc where ve.UsuInc =1
group by us.Usuario
--Trazer o valor total de vendas que Giomar realizou
select sum(ve.Valor) as 'Total de Vendas', us.Usuario from Vendas ve 
inner join Usuarios us on us.Id = ve.UsuInc where ve.UsuInc =2
group by us.Usuario

--Trazer a quantidade total de vendas que Felipe realizou
select count(ve.Valor) as 'Total de Vendas', us.Usuario from Vendas ve 
inner join Usuarios us on us.Id = ve.UsuInc where ve.UsuInc =1
group by us.Usuario
--Trazer a quantidade de vendas que Giomar realizou
select count(ve.Valor) as 'Total de Vendas', us.Usuario from Vendas ve 
inner join Usuarios us on us.Id = ve.UsuInc where ve.UsuInc =2
group by us.Usuario

--Trazer a quantidade total de vendas que Felipe e Giomar realizaram ordenando do maior para menor
select count(ve.Valor) as 'Total de Vendas', us.Usuario from Vendas ve 
inner join Usuarios us on us.Id = ve.UsuInc
group by us.Usuario
order by count(ve.Valor) desc
--Trazer o valor de vendas que Felipe e Giomar realizaram ordenando do maior para menor
select sum(ve.Valor) as 'Total de Vendas', us.Usuario from Vendas ve 
inner join Usuarios us on us.Id = ve.UsuInc 
group by us.Usuario
order by sum(ve.Valor) desc

--Trazer  a marca mais vendida de todos os anos
--	- Tradução "Retornar todas as marcas que foram vendidas mas ordernada da maior para menor"
select count(ve.Valor) as 'Vendas', ma.Nome from Carros ca
inner join Marcas ma on ma.Id = ca.Marca
inner join Vendas ve on ve.Carro = ca.Id
group by ma.Nome
order by count(ve.Valor) desc

--Trazer o valor total da marca mais vendida de todos os anos	
select top 1 sum(ve.Valor*ve.Quantidade) as 'Vendas', ma.Nome from Carros ca
inner join Marcas ma on ma.Id = ca.Marca
inner join Vendas ve on ve.Carro = ca.Id
group by ma.Nome
order by sum(ve.Valor) desc

--Trazer a quantidade do carro mais vendido de todos os anos
select top 1 sum(ve.Quantidade) as 'Vendas', ve.Carro from Vendas ve
inner join Carros ca on ve.Carro = ca.Id
group by ve.Carro
order by sum(ve.Valor) desc

--Trazer o valor do carro mais vendido de todos os anos*/ --******CORRIGIR para valor

select top 1 sum(ve.Quantidade) as 'Vendas', ve.Carro/*,ve.Valor*/ from Vendas ve
inner join Carros ca on ve.Carro = ca.Id
group by ve.Carro--, ve.Valor
order by sum(ve.Valor) desc