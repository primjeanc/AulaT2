insert into Usuarios
(Nome,Login,Senha) values
('Adagoberto','urineidson', '66tapanasoreia')
go
select * from Usuarios
update Usuarios set Ativo = 0 where Id in (10,8,7,6)