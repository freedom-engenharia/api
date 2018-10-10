
using AutomacaoFreedom.Entidade.Tipologia;
using AutomacaoFreedomApi.Infraestrutura.Enum;
using System;

namespace AutomacaoFreedomApi.Entidade.Hardware
{
    public class FreedomBoard : BaseEntidade
    {
        public int tipo { get; set; }
        public int statusRele01 { get; set; }
        public int statusRele02 { get; set; }
        public int statusRele03 { get; set; }
        public int statusRele04 { get; set; }
        public string topicoUpdateDevice { get; set; }
       

        public String statusDevice { get; set; }
    }
}




