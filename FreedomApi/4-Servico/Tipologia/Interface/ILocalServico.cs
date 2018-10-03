using AutomacaoFreedom.Entidade.Tipologia;
using AutomacaoFreedom.Modelo.Tipologia;
using AutomacaoFreedom.Modelos.Tipologia;
using System;
using System.Linq;

namespace AutomacaoFreedomApi.Servico.Tipologia.Interface
{
    public interface ILocalServico
    {

        IQueryable<Local> GetAll();
        LocalDto GetById(Guid id);
        LocalCreacaoDto Add(LocalCreacaoDto local);
        void Update(LocalAtuazacaoDto local);
        void Delete(LocalDto local);

    }
}