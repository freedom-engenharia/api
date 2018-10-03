
using AutomacaoFreedom.Entidade.Tipologia;
using AutomacaoFreedom.Entidades.Tipologia;
using AutomacaoFreedomApi.Modelo;
using System;

namespace AutomacaoFreedom.Modelo.Tipologia
{
    public class SubLocalDto : BaseModelo
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Logo { get; set; }

        public Guid? LocalId { get; set; }

        //Mapeando automaticamente o "Local"
        public string NomeLocal { get; set; }
        public string CodigoLocal { get; set; }
        public string Unidade { get; set; }

        internal void AffterMap(SubLocal origin)
        {
            if (origin.Local == null)
                return;

            NomeLocal = origin.Local.Nome;
            CodigoLocal = origin.Local.Codigo;
            Unidade = origin.Local.Unidade.Nome;
        }

    }
}
