using QuickBuy.Domain.Contratos;
using System.Collections.Generic;

namespace QuickBuy.Repository.Repositorios
{
    public class BaseRepositorioBase<T> : IBaseRepositorio<T> where T : class
    {

        public BaseRepositorioBase()
        {
            
        }
        public void Adicionar(T entity)
        {
            throw new System.NotImplementedException();
        }

        public void Atualizar(T entity)
        {
            throw new System.NotImplementedException();
        }

  

        public T ObterPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> ObterTodos()
        {
            throw new System.NotImplementedException();
        }

        public void Remover(T entity)
        {
            throw new System.NotImplementedException();
        }
        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}