using AutomacaoFreedom.Entidade.Tipologia;
using AutomacaoFreedom.Modelo.Tipologia;
using AutomacaoFreedom.Modelos.Tipologia;
using AutomacaoFreedomApi.Repositorio.Tipologia.Interface;
using AutomacaoFreedomApi.Servico.Tipologia.Interface;
using AutoMapper;
using System;
using System.Linq;

namespace AutomacaoFreedomApi.Servico.Tipologia.Concreta
{
    public class LocalServico : ILocalServico
    {
        private readonly ILocalRepositorio _repositorio;

        public LocalServico(ILocalRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public IQueryable<Local> GetAll()
        {
            var query = _repositorio.GetAll();
            return query;

        }

        public LocalDto GetById(Guid id)
        {
            var Local = _repositorio.GetById(id);
            var byLocal = Mapper.Map<LocalDto>(Local);
            return byLocal;
        }

        public LocalCreacaoDto Add(LocalCreacaoDto Local)
        {
            var novoLocal = Mapper.Map<Local>(Local);
            var creado = _repositorio.Add(novoLocal);
            var entidade = Mapper.Map<LocalCreacaoDto>(creado);
            return entidade;
        }

        public void Update(LocalAtuazacaoDto Local) =>
            _repositorio.Update(Mapper.Map<Local>(Local));

        public void Delete(LocalDto Local) =>
           _repositorio.Delete(Mapper.Map<Local>(Local));
    }
}
