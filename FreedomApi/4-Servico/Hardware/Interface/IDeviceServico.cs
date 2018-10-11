using AutomacaoFreedomApi.Entidade.Hardware;
using AutomacaoFreedomApi.Modelo.Hardware;
using System;
using System.Linq;

namespace AutomacaoFreedomApi.Servico.Hardware.Interface
{
    public interface IDeviceServico
    {

        IQueryable<Device> GetAll();
        DeviceDto GetById(Guid id);
        DeviceCriacaoDto Add(DeviceCriacaoDto device);
        void Update(DeviceAtualizacaoDto device);
        void Delete(DeviceDto device);

    }
}
