--select top 4* from Usuarios
--select top 2* from Vendas
--select top 2* from Carros 
--select top 2* from Marcas

/*Realizar um update das informações que contem usuario de criação 0 para o Id do usuario Felipe*/
update Marcas set UsuInc = 1 select * from Marcas where UsuInc = 0
--Trazer somente as marcas que Felipe cadastrou
select ma.Id, ma.Nome, us.Usuario from Marcas ma
inner join Usuarios us on us.Id = ma.UsuInc where us.Id =1
--Trazer somente as marcas que Giomar cadastrou
select ma.Id, ma.Nome, us.Usuario from Marcas ma
inner join Usuarios us on us.Id = ma.UsuInc where us.Id =2

/*Trazer somente a quantidade de marcas que Felipe cadastrou do maior para menor*/
select us.Usuario, count(us.Usuario) as 'Marcas' from Marcas ma
inner join Usuarios us on us.Id = ma.UsuInc where us.Id = 1
group by us.Usuario
order by count(us.Usuario) desc

/*Trazer somente a quantidade de marcas que Giomar cadastrou do menor para maior*/
select us.Usuario, count(us.Usuario) as 'Marcas' from Marcas ma
inner join Usuarios us on us.Id = ma.UsuInc where us.Id = 2
group by us.Usuario
order by count(us.Usuario) asc

/*Trazer somente a quantidade de marcas que Felipe e Giomar cadastraram */
select us.Usuario, count(us.Usuario) as 'Marcas' from Marcas ma
inner join Usuarios us on us.Id = ma.UsuInc 
group by us.Usuario
/*Trazer somente os carros que Felipe cadastrou*/
select us.Usuario, ca.Modelo from Carros ca
inner join Usuarios us on us.Id = ca.UsuInc where us.Id =1


/*Trazer somente os carros que Giomar cadastrou*/
select us.Usuario, ca.Modelo from Carros ca
inner join Usuarios us on us.Id = ca.UsuInc where us.Id =2


/*Trazer somente a quantidade de carros que Felipe cadastrou maior para menor*/
select us.Usuario, count(us.Usuario) from Carros ca
inner join Usuarios us on us.Id = ca.UsuInc where us.Id = 1
group by us.Usuario
order by us.Usuario desc

/*Trazer somente a quantidade de carros que Giomar cadastrou menor para maior*/
select us.Usuario, count(us.Usuario) from Carros ca
inner join Usuarios us on us.Id = ca.UsuInc where us.Id = 2
group by us.Usuario
order by us.Usuario asc

/*Trazer somente a quantidade de carros que Felipe e Giomar cadastraram */
select us.Usuario, count(us.Usuario) from Carros ca
inner join Usuarios us on us.Id = ca.UsuInc 
group by us.Usuario

/*Trazer somente os carros das marcas que Felipe cadastrou*/
select us.Usuario, ca.Modelo, ma.Nome as 'Marca' from Carros ca
inner join Usuarios us on us.Id = ca.UsuInc
inner join Marcas ma on ma.Id = ca.Marca where ma.UsuInc =1 --and us.Id =1  /*esse segundo filtro limitaria com os carros tbm felipe*/


/*Trazer somente os carros das marcas que Giomar cadastrou*/
select us.Usuario as 'Cadastrou carro', ca.Modelo, ma.Nome as 'Marca' from Carros ca
inner join Usuarios us on us.Id = ca.UsuInc
inner join Marcas ma on ma.Id = ca.Marca where ma.UsuInc =2 --and us.Id =2

/*Trazer somente a quantidade de carros das marcas que Felipe cadastrou maior para menor*/
select count(ca.Id) as 'Qtd' from Carros ca
inner join Marcas ma on ma.Id = ca.Marca 
inner join Usuarios us on us.Id = ca.UsuInc
where ma.UsuInc = 1 
order by count(ca.Id) desc

/*Trazer somente a quantidade de carros das marcas que Giomar cadastrou menor para maior*/
select count(ca.Id) as 'Qtd' from Carros ca
inner join Marcas ma on ma.Id = ca.Marca 
inner join Usuarios us on us.Id = ca.UsuInc
where ma.UsuInc = 2 
order by count(ca.Id) desc

--Trazer o valor total de vendas 2019 isolado
select sum(Valor*Quantidade) as 'Total de Vendas 2019' from Vendas where DatInc like '%2019%'

--Trazer a quantidade total de vendas 2019 isolado
select count(Valor) as 'Quantidade de Vendas 2019' from Vendas where DatInc like '%2019%'

--Trazer o valor total de vendas em cada ano e ordenar do maior para o menor
select sum(Valor*Quantidade) as 'Total de Vendas', year(DatInc) as 'Ano' from Vendas 
where year (DatInc) like '%2018%' or year (DatInc) like '%2019%' or year (DatInc) like '%2020%'
group by year( DatInc) 
order by sum(Valor*Quantidade) desc

--Trazer a quantidade de vendas em cada ano e ordenar do maior para o menor
select count(Valor) as 'Total de Vendas', year(DatInc) as 'Ano' from Vendas 
where year (DatInc) like '%2018%' or year (DatInc) like '%2019%' or year (DatInc) like '%2020%'
group by year( DatInc) 
order by sum(Valor) desc

--Trazer o mês de cada ano que retornou a maior quantidade de vendas  --*****************************************CORRIGIR
--		- Tradução "Retornar agrupado por mês e ordenar do maior para menor"
--TOP 3 xing ling

SELECT year(ven1.DatInc),
(	SELECT TOP 1 MONTH(ven.DatInc) FROM Vendas ven
     WHERE year(ven.DatInc) = year(ven1.DatInc)
  GROUP BY month(ven.DatInc)
  ORDER BY sum(ven.Quantidade) DESC)
FROM Vendas ven1
GROUP BY year(ven1.DatInc)
		
--Trazer o mês de cada ano que retornou o maior valor de vendas
--		- Tradução "Retornar agrupado por mês e ordenar do maior para menor"
select max(Valor) as 'Total de Vendas', year(DatInc) as 'Ano', month(DatInc) from Vendas 
group by year( DatInc) 
order by max(Valor) desc

--Trazer o valor total de vendas que Felipe realizou
select sum(ve.Valor*ve.Quantidade) as 'Total de Vendas', us.Usuario from Vendas ve 
inner join Usuarios us on us.Id = ve.UsuInc where ve.UsuInc =1
group by us.Usuario
--Trazer o valor total de vendas que Giomar realizou
select sum(ve.Valor*ve.Quantidade) as 'Total de Vendas', us.Usuario from Vendas ve 
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
select sum(ve.Valor*ve.Quantidade) as 'Total de Vendas', us.Usuario from Vendas ve 
inner join Usuarios us on us.Id = ve.UsuInc 
group by us.Usuario
order by sum(ve.Valor*ve.Quantidade) desc

--Trazer  a marca mais vendida de todos os anos
--	- Tradução "Retornar todas as marcas que foram vendidas mas ordernada da maior para menor"
select top 1 count(ve.Valor) as 'Vendas', ma.Nome as 'Marca' from Carros ca
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

--Trazer a quantidade do carro mais vendido de todos os anos --tanto o carro 27 como 71 tiveram 34 unidades
select top 1 sum(ve.Quantidade) as 'Vendas', ca.Modelo, ca.Id from Vendas ve
inner join Carros ca on ve.Carro = ca.Id
group by ca.Modelo, ca.Id 
order by sum(ve.Quantidade) desc

--Trazer o valor do carro mais vendido de todos os anos*/ --usado TOP 2 pois o primeiro e segundo tiveram mesmo valor de vendas
--select top 2 sum(ve.Quantidade) as 'Vendas', ca.Modelo, ca.Id from Vendas ve
--inner join Carros ca on ve.Carro = ca.Id
--group by ca.Modelo, ca.Id
--order by sum(ve.Quantidade) desc

SELECT top 1 avg(ve.Valor) as 'Valor' FROM VENDAS ve
inner join CARROS ca on ve.Carro = ca.Id
inner join Marcas ma on ca.Marca = ma.Id
group by ca.Modelo 
order by sum(ve.Quantidade) desc

