create database FloriculturaDB
go
use FloriculturaDB
go

create table Flores(
Id int primary key identity(1,1) not null,
Nome nvarchar(25),
Quantidade int

)
--inserir 5 flores na tabela
insert into Flores (Nome, Quantidade) values
('Flor A',5),
('Flor B',11),
('Flor C',2),
('Flor D',3),
('Flor E',8)

--mostrar lista de quantidade do maior para menor
select * from Flores
order by Quantidade desc
--mostrar total tipos de flores, se fosse quantidade seria SUM(Quantidade)
select count(nome) as ' Tipos de Flores' from Flores
