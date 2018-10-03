
using AutomacaoFreedomApi.Modelo;
using System;

namespace AutomacaoFreedom.Modelo.Tipologia
{
    public class UnidadeCriacaoDto : BaseModelo
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Logo { get; set; }

        public Guid EmpresaId { get; set; }
    }
}

