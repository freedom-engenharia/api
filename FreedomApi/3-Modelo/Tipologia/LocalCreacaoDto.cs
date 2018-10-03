
using AutomacaoFreedomApi.Modelo;
using System;
using System.Collections.Generic;

namespace AutomacaoFreedom.Modelo.Tipologia
{
    public class LocalCreacaoDto : BaseModelo
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Logo { get; set; }

        public virtual ICollection<SubLocalDto> SubLocais { get; set; }
        public UnidadeDto Unidade { get; set; }
        public Guid UnidadeId { get; set; }
    }
}

