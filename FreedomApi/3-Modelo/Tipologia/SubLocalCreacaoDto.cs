using AutomacaoFreedomApi.Modelo;
using System;

namespace AutomacaoFreedom.Modelos.Tipologia
{
    public class SubLocalCreacaoDto : BaseModelo
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Logo { get; set; }

        public Guid? LocalId { get; set; }

    }
}
