select c.Modelo, m.Nome as 'Marca', u.Nome as 'UsuarioCriacao', ua.Nome as 'UsuarioAlteracao' -- no SELECT escrevemos todas informacoes que queremos
from Carros c inner join Marcas m on c.MarcaCodigo = m.Codigo -- em inner join se executa uma validacao (codigo igual, ID usuario etc)
			  inner join Usuarios u on c.UsuarioCriacao = u.Id
			  inner join Usuarios ua on c.UsuarioAlteracao = ua.Id