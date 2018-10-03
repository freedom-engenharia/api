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
    public class SubLocalServico : ISubLocalServico
    {
        private readonly ISubLocalRepositorio _repositorio;

        public SubLocalServico(ISubLocalRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public IQueryable<SubLocal> GetAll()
        {
            var query = _repositorio.GetAll();
            return query;

        }

        public SubLocalDto GetById(Guid id)
        {
            var SubLocal = _repositorio.GetById(id);
            var bySubLocal = Mapper.Map<SubLocalDto>(SubLocal);
            return bySubLocal;
        }

        public SubLocalCreacaoDto Add(SubLocalCreacaoDto SubLocal)
        {
            var novoSubLocal = Mapper.Map<SubLocal>(SubLocal);
            var creado = _repositorio.Add(novoSubLocal);
            var entidade = Mapper.Map<SubLocalCreacaoDto>(creado);
            return entidade;
        }

        public void Update(SubLocalAtualizacaoDto SubLocal) =>
            _repositorio.Update(Mapper.Map<SubLocal>(SubLocal));

        public void Delete(SubLocalDto SubLocal) =>
           _repositorio.Delete(Mapper.Map<SubLocal>(SubLocal));

    }
}