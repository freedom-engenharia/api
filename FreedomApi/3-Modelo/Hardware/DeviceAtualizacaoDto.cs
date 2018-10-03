
using AutomacaoFreedomApi.Infraestrutura.Enum;
using System;

namespace AutomacaoFreedomApi.Modelo.Hardware
{
    public class DeviceAtualizacaoDto : BaseModelo
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public string IP { get; set; }
        public string Mac { get; set; }

        public DeviceStatus Status { get; set; }

        public Guid SubLocalId { get; set; }
    }
}
