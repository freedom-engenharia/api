using AutomacaoFreedomApi.Entidade.Hardware;
using AutomacaoFreedomApi.Repositorio;
using System.Linq;

namespace AutomacaoFreedomApi.Repositorios.Hardware.Interface
{
    public interface IDeviceRepositorio : IBaseRepositorio<Device>
    {
        IQueryable<Device> GetAll();
        Device GetByIP(string IP);
    }
}
