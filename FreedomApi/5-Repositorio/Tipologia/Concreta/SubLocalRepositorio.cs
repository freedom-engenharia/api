using AutomacaoFreedom.Entidade.Tipologia;
using AutomacaoFreedom.Repositorios;
using AutomacaoFreedomApi.Repositorio.Base;
using AutomacaoFreedomApi.Repositorio.Tipologia.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AutomacaoFreedomApi.Repositorios.Tipologia.Concreta
{
    public class SubLocalRepositorio : BaseRepositorio<SubLocal>, ISubLocalRepositorio
    {
        private readonly AutomacaoFreedomContexto _contexto;
        public SubLocalRepositorio(AutomacaoFreedomContexto contexto) : base(contexto)
        {
            _contexto = contexto;

        }

        public IQueryable<SubLocal> GetAll()
        {
            var subLocais = _contexto.SubLocal.Include( x => x.Local.Unidade);
            return subLocais;
        }
    }
}
