
using System;

namespace AutomacaoFreedomApi.Modelo
{
    public class BaseModelo
    {
        public BaseModelo() { }

        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataModificacao { get; set; }
    }
}
