insert into Livros
(Nome) values 
('A ordem das batatas n�o altera a maionese'), 
('XGH Principiante'), 
('XGH Avan�ado'),
('Ahhhhh Bati o dedinho na quina'),
('Programador tamb�m � gente')
--teoricamente precisaria de ';' ou 'GO' a cada tarefa
update Livros set Ativo = 0 where Id = 4

select Id,Nome,DataCriacao from Livros where Ativo = 1
go