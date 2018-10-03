
using AutomacaoFreedomApi.Entidade;
using System.Collections.Generic;

namespace AutomacaoFreedom.Entidade.Tipologia
{
    public class Empresa : BaseEntidade
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Logo { get; set; }

        public virtual ICollection<Unidade> Unidades { get; set; }

    }
}

