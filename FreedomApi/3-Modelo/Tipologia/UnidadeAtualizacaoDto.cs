
using AutomacaoFreedomApi.Modelo;
using System;

namespace AutomacaoFreedom.Entidades.Tipologia
{
    public class UnidadeAtualizacaoDto : BaseModelo
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Logo { get; set; }

        public Guid EmpresaId { get; set; }
    }
}

