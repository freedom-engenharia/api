using AutomacaoFreedom.Entidade.Tipologia;
using AutomacaoFreedomApi.Modelo.Tipologia;
using AutomacaoFreedomApi.Repositorio.Tipologia.Interface;
using AutomacaoFreedomApi.Servico.Tipologia.Interface;
using AutoMapper;
using System;
using System.Linq;

namespace AutomacaoFreedomApi.Servico.Tipologia.Concreta
{
    public class EmpresaServico : IEmpresaServico
    {
        private readonly IEmpresaRepositorio _repositorio;

        public EmpresaServico(IEmpresaRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public IQueryable<Empresa> GetAll()
        {
            var query = _repositorio.GetAll();
            return query;

        }

        public EmpresaDto GetById(Guid id)
        {
            var Empresa = _repositorio.GetById(id);
            var byEmpresa = Mapper.Map<EmpresaDto>(Empresa);
            return byEmpresa;
        }

        public EmpresaDto Add(EmpresaDto Empresa)
        {
            var novoEmpresa = Mapper.Map<Empresa>(Empresa);
            var creado = _repositorio.Add(novoEmpresa);
            var entidade = Mapper.Map<EmpresaDto>(creado);
            return entidade;
        }

        public void Update(EmpresaDto Empresa) =>
            _repositorio.Update(Mapper.Map<Empresa>(Empresa));

        public void Delete(EmpresaDto Empresa) =>
           _repositorio.Delete(Mapper.Map<Empresa>(Empresa));
    }
}
