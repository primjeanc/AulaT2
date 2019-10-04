--create database Musicas
--go
--use Musicas
--go

--create table PlayList
--(
--Id int primary key identity (1,1),
--Nome nvarchar(35) not null,
--Artista nvarchar(35),
--Genero nvarchar(35)
--)
--GO

--insert into PlayList (Nome, Artista, Genero) values
--('Marriage of Figaro','	Mozart','Classic'),
--('Girls like You','Maroom 5','POP'),
--('Everlong','Foo Fighters','Rock'),
--('American Jesus','Bad Religion','Rock'),
--('Pathetique Sonata - Adagio','Beethoven','Classic'),
--('5th Symphony','Beethoven','Classic'),
--('Infected','Bad Religion','Rock'),
--('Wrong Way Kids','Bad Religion','Rock'),
--('Better off Dead','Bad Religion','Rock'),
--('Los Angeles is Burning','Bad Religion','Rock')

--select Genero from PlayList group by Genero--retorna os generos
--select count (Genero) as 'Títulos', Genero from PlayList group by Genero --qtd musicas por genero

--select Artista, count(Nome) as 'Musicas' from PlayList group by Artista--retorna os generos

--select distinct Genero from PlayList

--/*-----------------------------------------------*/

--create table Generos(
--Id int primary key identity (1,1),
--Nome nvarchar(35) not null
--)
--GO
--create table Artistas(
--Id int primary key identity (1,1),
--IdGen int,
--Nome nvarchar(35) not null,
--constraint [FK_Artistas_Generos] foreign key (IdGen) references Generos(Id)
--)
--GO
--create table Songs(
--Id int primary key identity (1,1),
--IdArt int,
--Nome nvarchar(35) not null,
--constraint [FK_Songs_Artistas] foreign key (IdArt) references Artistas(Id)
--)
--GO

--insert into Generos (Nome) values
--('Classic'),('POP'),('Rock')

--insert into Artistas (Nome, IdGen) values
--('Mozart',1),
--('Maroom 5',2),
--('Foo Fighters',3),
--('Bad Religion',3),
--('Beethoven',1),
--('Beethoven',1),
--('Bad Religion',3),
--('Bad Religion',3),
--('Bad Religion',3),	
--('Bad Religion',3)	

--insert into Songs (Nome, IdArt) values
--('Marriage of Figaro',1),		
--('Girls like You',2),		
--('Everlong',3),			
--('American Jesus',4),			
--('Pathetique Sonata - Adagio',1),	
--('5th Symphony',1),			
--('Infected',4),					
--('Wrong Way Kids',4),			
--('Better off Dead',4),			
--('Los Angeles is Burning',4)	

/*---------------------*/
select ge.Nome as 'Genero', ar.Nome as 'Artista', so.Nome as 'Musica'
from Generos ge
inner join Artistas ar on ge.Id = ar.IdGen
inner join Songs so on ar.Id = so.IdArt


select ge.Nome as 'Genero' , count (ar.Nome) as ' Quantidade Artistas'
from Generos ge
inner join Artistas ar on ge.Id = ar.IdGen
group by ge.Nome

select ge.Nome as 'Genero' , count (so.Nome) as ' Quantidade Canções'
from Generos ge
inner join Artistas ar on ge.Id = ar.IdGen
inner join Songs so on ar.Id = so.IdArt
group by ge.Nome