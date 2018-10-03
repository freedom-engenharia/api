
using AutomacaoFreedom.Entidade.Tipologia;
using AutomacaoFreedom.Modelo.Tipologia;
using AutomacaoFreedomApi.Modelo;
using System;
using System.Collections.Generic;

namespace AutomacaoFreedom.Modelos.Tipologia
{
    public class LocalDto: BaseModelo
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Logo { get; set; }

        public virtual ICollection<SubLocalDto> SubLocais { get; set; }

        public Guid UnidadeId { get; set; }

        //Mapeando automaticamente o "Unidade"
        public string NomeUnidade { get; set; }
        public string CodigoUnidade { get; set; }

        internal void AffterMap(Local origin)
        {
            if (origin.Unidade == null)
                return;

            NomeUnidade = origin.Unidade.Nome;
            CodigoUnidade = origin.Unidade.Codigo;
        }

    }
}

