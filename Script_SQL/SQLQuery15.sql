UPDATE Livros SET Ativo=0 WHERE Id =
(SELECT Id FROM Livros ORDER BY Id DESC OFFSET 1 ROWS FETCH NEXT 1 ROWS only)--esse Select pega sempre o penultimo item
--UPDATE atualiza informacoes, Livros é a tabela escolhida, SET inicializa a primera alteração no sql
--Ativo =0, expressao a alterar, WHERE condicoes/filtro, 
