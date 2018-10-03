using AutomacaoFreedom.Entidade.Tipologia;
using System.Linq;

namespace AutomacaoFreedomApi.Repositorio.Tipologia.Interface
{
    public interface ISubLocalRepositorio : IBaseRepositorio<SubLocal>
    {
        IQueryable<SubLocal> GetAll();
    }
}
