
using AutomacaoFreedom.Entidade.Tipologia;
using AutomacaoFreedom.Entidades.Tipologia;
using AutomacaoFreedom.Modelo.Tipologia;
using System;
using System.Linq;

namespace AutomacaoFreedomApi.Servico.Tipologia.Interface
{
    public interface IUnidadeServico
    {

        IQueryable<Unidade> GetAll();
        UnidadeDto GetById(Guid id);
        UnidadeCriacaoDto Add(UnidadeCriacaoDto unidade);
        void Update(UnidadeAtualizacaoDto unidade);
        void Delete(UnidadeDto unidade);

    }
}