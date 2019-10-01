select c.Modelo,m.Nome,c.Placa,c.Ano 
from Carros c inner join Marcas m on c.MarcaCodigo = m.Codigo
-- from carros INNER JOIN Marcas = pega tabela Carros e adiciona informacoes de Marcas nela
--on c.MarcaCodigo = m.Codigo >> confere igualdade e retorna valor da segunda tabela "PROCV do excel"
--inner join = relaciona e junta tabelas
order by c.Ano desc