
using AutomacaoFreedom.Entidade.Tipologia;
using AutomacaoFreedom.Modelo.Tipologia;
using AutomacaoFreedom.Modelos.Tipologia;
using System;
using System.Linq;

namespace AutomacaoFreedomApi.Servico.Tipologia.Interface
{
    public interface ISubLocalServico
    {

        IQueryable<SubLocal> GetAll();
        SubLocalDto GetById(Guid id);
        SubLocalCreacaoDto Add(SubLocalCreacaoDto subLocal);
        void Update(SubLocalAtualizacaoDto subLocal);
        void Delete(SubLocalDto subLocal);

    }
}