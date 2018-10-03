using AutomacaoFreedomApi.Entidade;
using System;

namespace AutomacaoFreedomApi.Repositorio
{
    public interface IBaseRepositorio<TEntity> where TEntity : BaseEntidade
    {
        void Delete(TEntity entity);
        void Update(TEntity entity);
        TEntity Add(TEntity entity);
        TEntity GetById(Guid id);
    }
}
