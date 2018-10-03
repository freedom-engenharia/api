
using AutomacaoFreedomApi.Entidade;
using System;
using System.Collections.Generic;

namespace AutomacaoFreedom.Entidade.Tipologia
{
    public class Unidade : BaseEntidade
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Logo { get; set; }

        public virtual Empresa Empresa { get; set; }
        public Guid EmpresaId { get; set; }

        public virtual ICollection<Local> Locais { get; set; }

    }
}

