using AutomacaoFreedom.Entidade.Tipologia;
using AutomacaoFreedomApi.Repositorio;
using System.Linq;

namespace AutomacaoFreedomApi.Repositorio.Tipologia.Interface
{
    public interface ILocalRepositorio : IBaseRepositorio<Local>
    {
        IQueryable<Local> GetAll();
    }
}
