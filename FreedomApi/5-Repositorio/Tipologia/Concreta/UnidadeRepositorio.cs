
using AutomacaoFreedom.Entidade.Tipologia;
using AutomacaoFreedom.Repositorios;
using AutomacaoFreedomApi.Repositorio.Base;
using AutomacaoFreedomApi.Repositorio.Tipologia.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AutomacaoFreedomApi.Repositorio.Tipologia.Concreta
{
    public class UnidadeRepositorio : BaseRepositorio<Unidade>, IUnidadeRepositorio
    {
        private readonly AutomacaoFreedomContexto _contexto;
        public UnidadeRepositorio(AutomacaoFreedomContexto contexto) : base(contexto)
        {
            _contexto = contexto;

        }

        public IQueryable<Unidade> GetAll()
        {
            var unidades = _contexto.Unidade.Include(x => x.Empresa);
            return unidades;
        }
    }
}
