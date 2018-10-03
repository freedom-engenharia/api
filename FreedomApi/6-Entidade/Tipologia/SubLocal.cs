
using AutomacaoFreedomApi.Entidade;
using AutomacaoFreedomApi.Entidade.Hardware;
using System;
using System.Collections.Generic;

namespace AutomacaoFreedom.Entidade.Tipologia
{
    public class SubLocal : BaseEntidade
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Logo { get; set; }

        public virtual ICollection<Device> Devices { get; set; }

        public virtual Local Local { get; set; }
        public Guid? LocalId { get; set; }
    }
}
