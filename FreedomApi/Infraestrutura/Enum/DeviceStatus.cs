
using System.ComponentModel.DataAnnotations;

namespace AutomacaoFreedomApi.Infraestrutura.Enum
{
    public enum DeviceStatus
    {
        [Display(Name = "Ligado")]
        LIGADO = 1,

        [Display(Name = "Desligado")]
        DESLIGADO = 0,
    }
}