select * from Usuarios where Ativo = 1
--Select >palavra reservada que seleciona dados
--* >indica selecao completa "all"
--from > palav. reservada sql que indica qual tabela estamos acessando
--Usuarios >tabela selecionada
--where >indicador que vamos realizar filtro
--Ativo > coluna do filtro
--= 1> 'igual' indica igualdade/comparacao, '1' valor comparado, no caso ativo 'true'
update Usuarios set Nome = 'Jean' where Id = 2
update Usuarios set Nome = 'Motocicleiton' where Id = 3
go