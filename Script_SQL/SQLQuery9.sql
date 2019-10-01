insert into Livros
(Nome) values 
('A ordem das batatas não altera a maionese'), 
('XGH Principiante'), 
('XGH Avançado'),
('Ahhhhh Bati o dedinho na quina'),
('Programador também é gente')
--teoricamente precisaria de ';' ou 'GO' a cada tarefa
update Livros set Ativo = 0 where Id = 4

select Id,Nome,DataCriacao from Livros where Ativo = 1
go