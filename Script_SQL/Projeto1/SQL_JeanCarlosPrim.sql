create database BaseDeDadosHbsis --nome BaseDeDadosHbsis
GO
use BaseDeDadosHbsis
GO

if not exists (select * from sysobjects where name = 'Veiculos' and xtype = 'U')
create table Tipos--[0]carro [1]moto
(
Id int primary key identity(1,1) not null,
Codigo bit default ((1)),
Tipo nvarchar(5)not null,--nvarchar teoricamente ordena melhor na tabela posteriormente
Ativo bit default ((1))

)
GO
if not exists (select * from sysobjects where name = 'Marcas' and xtype = 'U')
create table Marcas--[0]carro [1]moto
(
Id int primary key identity(1,1) not null,
Codigo int,
Marca nchar(25),
TipoVeiculo bit default ((1)),

Ativo bit default ((1)),
UsuarioCriacao INT DEFAULT ((0)),
UsuarioAlteracao INT DEFAULT ((0)),
DataCriacao datetime default getdate(),
DataAlteracao datetime default getdate()
)
GO
create table Modelos
(
Id int primary key identity(1,1) not null,
Codigo int,
Modelo nchar(25),
CodMarca int,

Ativo bit default ((1)),
UsuarioCriacao INT DEFAULT ((0)),
UsuarioAlteracao INT DEFAULT ((0)),
DataCriacao datetime default getdate(),
DataAlteracao datetime default getdate()
)
GO

--BONUS
insert into Tipos (Codigo, Tipo) values
(0,'Carro'),(1,'Moto')
GO
insert into Marcas (Codigo, Marca, TipoVeiculo) values
(1,'Audi',0),(2,'BMW',0),(3,'Chevrolet',0),(4,'Citröen',0),
(5,'Fiat',0),(6,'Ford',0),(7,'Honda',0),(8,'Hyundai',0),
(9,'Jeep',0),(10,'Kia',0),(11,'Mitsubishi',0),(12,'Nissan',0),
(13,'Peugeot',0),(14,'Renault',0),(15,'Toyota',0),(16,'Volkswagen',0),
(5,'Kawasaki',1)
GO

insert into Modelos (Codigo, Modelo, CodMarca) values
(1,'100',1),
(2,'100 Avant',1),
(3,'80',1),
(4,'80 Avant',1),
(5,'80 Cabriolet',1),
(6,'A1',1),
(382,'Sportage',10),
(383,'Stinger',10),
(816,'Z 800',5),
(817,'Z 900',5)
GO

--Pesquisa kawasaki(adicionado 2 motos kawasaki para teste)
select 
ti.Tipo as	'Veiculo', ma.Marca as 'Marca', mo.Modelo 
from Marcas ma inner join Modelos mo on ma.Codigo= mo.CodMarca 
			   inner join Tipos ti on ti.Codigo = ma.TipoVeiculo
		where (ma.Codigo = 5) and (ti.Codigo = 1)	
GO
		
--Pesquisa Kia (adicionado 2 carros da KIA para teste)
select 
ti.Tipo as	'Veiculo', ma.Marca as 'Marca', mo.Modelo 
from Marcas ma inner join Modelos mo on ma.Codigo= mo.CodMarca 
			   inner join Tipos ti on ti.Codigo = ma.TipoVeiculo
		where (ma.Codigo = 10) and (ti.Codigo = 0)	
GO