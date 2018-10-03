
using AutomacaoFreedom.Entidade.Tipologia;
using AutomacaoFreedom.Repositorios;
using AutomacaoFreedomApi.Repositorio.Base;
using AutomacaoFreedomApi.Repositorio.Tipologia.Interface;
using System.Linq;

namespace AutomacaoFreedomApi.Repositorio.Tipologia.Concreta
{
    public class EmpresaRepositorio : BaseRepositorio<Empresa>, IEmpresaRepositorio
    {
        private readonly AutomacaoFreedomContexto _contexto;
        public EmpresaRepositorio(AutomacaoFreedomContexto contexto) : base(contexto)
        {
            _contexto = contexto;

        }

        public IQueryable<Empresa> GetAll()
        {
            var empresas = _contexto.Empresa;
            return empresas;
        }
    }
}
