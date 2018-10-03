using AutomacaoFreedom.Entidade.Tipologia;
using AutomacaoFreedom.Entidades.Tipologia;
using AutomacaoFreedom.Modelo.Tipologia;
using AutomacaoFreedomApi.Repositorio.Tipologia.Interface;
using AutomacaoFreedomApi.Servico.Tipologia.Interface;
using AutoMapper;
using System;
using System.Linq;

namespace AutomacaoFreedomApi.Servico.Tipologia.Concreta
{
    public class UnidadeServico : IUnidadeServico
    {
        private readonly IUnidadeRepositorio _repositorio;

        public UnidadeServico(IUnidadeRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

            public IQueryable<Unidade> GetAll()
        {
            var query = _repositorio.GetAll();
            return query;

        }

        public UnidadeDto GetById(Guid id)
        {
            var Unidade = _repositorio.GetById(id);
            var byUnidade = Mapper.Map<UnidadeDto>(Unidade);
            return byUnidade;
        }

        public UnidadeCriacaoDto Add(UnidadeCriacaoDto Unidade)
        {
            var novoUnidade = Mapper.Map<Unidade>(Unidade);
            var creado = _repositorio.Add(novoUnidade);
            var entidade = Mapper.Map<UnidadeCriacaoDto>(creado);
            return entidade;
        }

        public void Update(UnidadeAtualizacaoDto Unidade) =>
            _repositorio.Update(Mapper.Map<Unidade>(Unidade));

        public void Delete(UnidadeDto Unidade) =>
           _repositorio.Delete(Mapper.Map<Unidade>(Unidade));
    }
}
