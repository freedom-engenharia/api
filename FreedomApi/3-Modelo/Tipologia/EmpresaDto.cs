using AutomacaoFreedom.Entidades.Tipologia;
using AutomacaoFreedom.Modelo.Tipologia;
using System.Collections.Generic;

namespace AutomacaoFreedomApi.Modelo.Tipologia
{
    public class EmpresaDto : BaseModelo
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Logo { get; set; }

        public ICollection<UnidadeDto> Unidades { get; set; }
    }
}
