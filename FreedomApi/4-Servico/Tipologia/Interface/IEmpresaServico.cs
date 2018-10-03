
using AutomacaoFreedom.Entidade.Tipologia;
using AutomacaoFreedomApi.Modelo.Tipologia;
using System;
using System.Linq;

namespace AutomacaoFreedomApi.Servico.Tipologia.Interface
{
    public interface IEmpresaServico
    {

        IQueryable<Empresa> GetAll();
        EmpresaDto GetById(Guid id);
        EmpresaDto Add(EmpresaDto empresa);
        void Update(EmpresaDto empresa);
        void Delete(EmpresaDto empresa);

    }
}