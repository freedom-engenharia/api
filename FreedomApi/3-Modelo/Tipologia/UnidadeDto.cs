
using AutomacaoFreedom.Entidade.Tipologia;
using AutomacaoFreedomApi.Modelo;
using System;

namespace AutomacaoFreedom.Modelo.Tipologia
{
    public class UnidadeDto : BaseModelo
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Logo { get; set; }

        public string NomeEmpresa { get; set; }
        public string CodigoEmpresa { get; set; }
        public Guid EmpresaId { get; set; }

        internal void AffterMap(Unidade origin)
        {
            if (origin.Empresa == null)
                return;

            NomeEmpresa = origin.Empresa.Nome;
            CodigoEmpresa = origin.Empresa.Codigo;
        }
    }
}

