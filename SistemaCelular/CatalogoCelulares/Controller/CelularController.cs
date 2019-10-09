using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCelulares.Model;

namespace CatalogoCelulares.Controller
{
    public class CelularController
    {
        CelularesContextDB contextDB = new CelularesContextDB();
        //listagem
        /// <summary>
        /// Metodo para listar registros ativos(true)
        /// </summary>
        /// <returns></returns>
        public IQueryable<Celular> GetCelulares()
        {
            return contextDB.Celulares.Where(x => x.Ativo ==true);
        }
        //atualizacao
        /// <summary>
        /// Metodo para atualizar e salvar dados de um celular existente
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool AtualizarCelular(Celular item)
        {
            var celular =//variavel para o celular
            contextDB.Celulares.FirstOrDefault(x => x.Id == item.Id);
            //BD      tabela    busca na tabela o celular
            //Compara os IDs e verifica se encontrou o celular
            if (celular == null)
                return false;
            else
            celular = item;
            celular.DataAlteracao = DateTime.Now;
            contextDB.SaveChanges();// salva apos confirmar IDs iguais
            return true;
        }
        //inserçao
        /// <summary>
        /// Metodo para adicionar Celular, ja verificando e barrando cadastros incorretos
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool AddCelular(Celular item)
        {
            if (string.IsNullOrWhiteSpace(item.Marca))// metodo que identifica espacos em branco
                return false;
            if (string.IsNullOrWhiteSpace(item.Modelo))
                return false;
            if (item.Preco <= 0)
                return false;
            contextDB.Celulares.Add(item);
            contextDB.SaveChanges();
            //retorna verdadeiro como sucesso da insersao de registro de celular
            return true;

        }
        //remoção
        /// <summary>
        /// Metodo para "desativar id" alterando Ativo para false, ja que a listagem busca apenas ativo true
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool RemoverCelular(int id)
        {
            var celular =
                contextDB.Celulares.FirstOrDefault(x => x.Id == id);
            //  BD        Tabela    busca de ID
            if (celular == null)//verifica se o item n existe
                return false;
            //retorna o celular encontrado atualizando o ATIVO para FALSE
            celular.Ativo = false;
            contextDB.SaveChanges();

            return true;
        }



    }
}
