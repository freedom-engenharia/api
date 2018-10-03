
using AutomacaoFreedom.Entidade.Tipologia;
using AutomacaoFreedomApi.Infraestrutura.Enum;
using System;

namespace AutomacaoFreedomApi.Entidade.Hardware
{
    public class Device: BaseEntidade
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public string IP { get; set; }
        public string Mac { get; set; }

        public DeviceStatus Status { get; set; }

        public virtual SubLocal SubLocal { get; set; }
        public Guid SubLocalId { get; set; }
    }
}
