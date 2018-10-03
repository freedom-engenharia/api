using AutomacaoFreedom.Entidade.Tipologia;
using System.Linq;

namespace AutomacaoFreedomApi.Repositorio.Tipologia.Interface
{
    public interface IUnidadeRepositorio : IBaseRepositorio<Unidade>
    {
        IQueryable<Unidade> GetAll();
    }
}
