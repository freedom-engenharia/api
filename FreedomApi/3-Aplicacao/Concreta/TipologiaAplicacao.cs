using AutomacaoFreedom.Entidades.Tipologia;
using AutomacaoFreedom.Modelo.Tipologia;
using AutomacaoFreedom.Modelos.Tipologia;
using AutomacaoFreedomApi.Aplicacao.Interface;
using AutomacaoFreedomApi.Modelo.Tipologia;
using AutomacaoFreedomApi.Servico.Tipologia.Interface;
using AutoMapper;
using System;
using System.Collections.Generic;

namespace AutomacaoFreedomApi.Aplicacao.Concreta
{
    public class TipologiaAplicacao : ITipologiaAplicacao
    {
        private readonly ISubLocalServico _subLocalServico;
        private readonly IUnidadeServico _unidadeServico;
        private readonly ILocalServico _localServico;
        private readonly IEmpresaServico _empresaServico;

        public TipologiaAplicacao(ISubLocalServico subLocalServico, IUnidadeServico unidadeServico,
            ILocalServico localServico, IEmpresaServico empresaServico)
        {

            _localServico = localServico;
            _unidadeServico = unidadeServico;
            _empresaServico = empresaServico;
            _subLocalServico = subLocalServico;
        }
        #region SubLocal

        public IEnumerable<SubLocalDto> GetSubLocais() =>
           Mapper.Map<IEnumerable<SubLocalDto>>(_subLocalServico.GetAll());

        public SubLocalDto GetSubLocalById(Guid id) =>
             _subLocalServico.GetById(id);

        public SubLocalCreacaoDto AddSubLocal(SubLocalCreacaoDto subLocal) =>
            _subLocalServico.Add(subLocal);

        public void UpdateSubLocal(SubLocalAtualizacaoDto subLocal) =>
            _subLocalServico.Update(subLocal);

        public void DeleteSubLocal(SubLocalDto subLocal) =>
            _subLocalServico.Delete(subLocal);

        #endregion

        #region Local

        public IEnumerable<LocalDto> GetLocais() =>
           Mapper.Map<IEnumerable<LocalDto>>(_localServico.GetAll());

        public LocalDto GetLocalById(Guid id) =>
             _localServico.GetById(id);

        public LocalCreacaoDto AddLocal(LocalCreacaoDto local) =>
            _localServico.Add(local);

        public void UpdateLocal(LocalAtuazacaoDto local) =>
            _localServico.Update(local);

        public void DeleteLocal(LocalDto local) =>
            _localServico.Delete(local);

        #endregion


        #region Unidade

        public IEnumerable<UnidadeDto> GetUnidades() =>
            Mapper.Map<IEnumerable<UnidadeDto>>(_unidadeServico.GetAll());

        public UnidadeDto GetUnidadeById(Guid id) =>
             _unidadeServico.GetById(id);

        public UnidadeCriacaoDto AddUnidade(UnidadeCriacaoDto unidade) =>
            _unidadeServico.Add(unidade);

        public void UpdateUnidade(UnidadeAtualizacaoDto unidade) =>
            _unidadeServico.Update(unidade);

        public void DeleteUnidade(UnidadeDto unidade) =>
            _unidadeServico.Delete(unidade);

        #endregion

        #region Empresa

        public IEnumerable<EmpresaDto> GetEmpresas() =>
            Mapper.Map<IEnumerable<EmpresaDto>>(_empresaServico.GetAll());

        public EmpresaDto GetEmpresaById(Guid id) =>
             _empresaServico.GetById(id);

        public EmpresaDto AddEmpresa(EmpresaDto empresa) =>
            _empresaServico.Add(empresa);

        public void UpdateEmpresa(EmpresaDto empresa) =>
            _empresaServico.Update(empresa);

        public void DeleteEmpresa(EmpresaDto empresa) =>
            _empresaServico.Delete(empresa);

        #endregion

    }
}

        