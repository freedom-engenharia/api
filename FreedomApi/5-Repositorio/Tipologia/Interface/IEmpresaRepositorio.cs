using AutomacaoFreedom.Entidade.Tipologia;
using AutomacaoFreedomApi.Repositorio;
using System.Linq;

namespace AutomacaoFreedomApi.Repositorio.Tipologia.Interface
{
    public interface IEmpresaRepositorio : IBaseRepositorio<Empresa>
    {
        IQueryable<Empresa> GetAll();
    }
}
