
using AutomacaoFreedom.Entidade.Tipologia;
using AutomacaoFreedom.Repositorios;
using AutomacaoFreedomApi.Repositorio.Base;
using AutomacaoFreedomApi.Repositorio.Tipologia.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AutomacaoFreedomApi.Repositorios.Tipologia.Concreta
{
    public class LocalRepositorio : BaseRepositorio<Local>, ILocalRepositorio
    {
        private readonly AutomacaoFreedomContexto _contexto;
        public LocalRepositorio(AutomacaoFreedomContexto contexto) : base(contexto)
        {
            _contexto = contexto;

        }

        public IQueryable<Local> GetAll()
        {
            var locais = _contexto.Local.Include(x => x.Unidade);
            return locais;
        }
    }
}
