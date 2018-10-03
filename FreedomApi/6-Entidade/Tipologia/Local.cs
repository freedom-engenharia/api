
using AutomacaoFreedomApi.Entidade;
using System;
using System.Collections.Generic;

namespace AutomacaoFreedom.Entidade.Tipologia
{
    public class Local: BaseEntidade
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Logo { get; set; }

        public virtual ICollection<SubLocal> SubLocais { get; set; }

        public virtual Unidade Unidade { get; set; }
        public Guid UnidadeId { get; set; }
    }
}

