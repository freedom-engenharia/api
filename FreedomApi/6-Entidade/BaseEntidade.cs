
using System;

namespace AutomacaoFreedomApi.Entidade
{
    public class BaseEntidade
    {
        public BaseEntidade() { }

        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataModificacao { get; set; }
    }
}
