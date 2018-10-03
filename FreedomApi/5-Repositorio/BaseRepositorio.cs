using AutomacaoFreedom.Repositorios;
using AutomacaoFreedomApi.Entidade;
using System;

namespace AutomacaoFreedomApi.Repositorio.Base
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : BaseEntidade
    {
        private readonly AutomacaoFreedomContexto _contexto;

        public BaseRepositorio(AutomacaoFreedomContexto contexto)
        {
            _contexto = contexto;
        }

        public void Delete(TEntity entity) =>
            _contexto.Remove<TEntity>(_contexto.Find<TEntity>(entity.Id));

        public void Update(TEntity entity) =>
            _contexto.Update<TEntity>(entity);

        public TEntity Add(TEntity entity)
        {
            var createde = _contexto.Add<TEntity>(entity);
            return createde.Entity;
        }

        public TEntity GetById(Guid id)
        {
            var entity = _contexto.Find<TEntity>(id);
            return entity;
        }
    }
}


