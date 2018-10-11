

using AutomacaoFreedom.Repositorios;
using AutomacaoFreedomApi.Entidade.Hardware;
using AutomacaoFreedomApi.Repositorio.Base;
using AutomacaoFreedomApi.Repositorios.Hardware.Interface;
using System.Linq;

namespace AutomacaoFreedomApi.Repositorio.Hardware.Concreta
{
    public class DeviceRepositorio: BaseRepositorio<Device>, IDeviceRepositorio
    {
        private readonly AutomacaoFreedomContexto _contexto;
        public DeviceRepositorio(AutomacaoFreedomContexto contexto) : base(contexto)
        {
            _contexto = contexto;

        }

        public IQueryable<Device> GetAll()
        {
            var devices = _contexto.Device;
            return devices;
        }

    }
}
