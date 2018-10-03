
using AutomacaoFreedom.Entidades.Tipologia;
using AutomacaoFreedom.Modelo.Tipologia;
using AutomacaoFreedom.Modelos.Tipologia;
using AutomacaoFreedomApi.Modelo.Tipologia;
using System;
using System.Collections.Generic;

namespace AutomacaoFreedomApi.Aplicacao.Interface
{
    public interface ITipologiaAplicacao
    {
        #region SubLocal

        IEnumerable<SubLocalDto> GetSubLocais();
        SubLocalDto GetSubLocalById(Guid id);
        SubLocalCreacaoDto AddSubLocal(SubLocalCreacaoDto subLocal);
        void UpdateSubLocal(SubLocalAtualizacaoDto subLocal);
        void DeleteSubLocal(SubLocalDto subLocal);

        #endregion

        #region Local

        IEnumerable<LocalDto> GetLocais();
        LocalDto GetLocalById(Guid id);
        LocalCreacaoDto AddLocal(LocalCreacaoDto local);
        void UpdateLocal(LocalAtuazacaoDto local);
        void DeleteLocal(LocalDto local);

        #endregion

        #region Unidade

        IEnumerable<UnidadeDto> GetUnidades();
        UnidadeDto GetUnidadeById(Guid id);
        UnidadeCriacaoDto AddUnidade(UnidadeCriacaoDto unidade);
        void UpdateUnidade(UnidadeAtualizacaoDto unidade);
        void DeleteUnidade(UnidadeDto unidade);

        #endregion

        #region Empresa

        IEnumerable<EmpresaDto> GetEmpresas();
        EmpresaDto GetEmpresaById(Guid id);
        EmpresaDto AddEmpresa(EmpresaDto empresa);
        void UpdateEmpresa(EmpresaDto empresa);
        void DeleteEmpresa(EmpresaDto empresa);

        #endregion
    }
}

       