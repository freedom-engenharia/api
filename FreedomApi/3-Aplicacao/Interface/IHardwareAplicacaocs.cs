using AutomacaoFreedomApi.Modelo.Hardware;
using System;
using System.Collections.Generic;

namespace AutomacaoFreedomApi.Aplicacao.Interface
{
    public interface IHardwareAplicacao
    {
        #region Device

        IEnumerable<DeviceDto> GetDevices();
        DeviceDto GetDeviceById(Guid id);
        DeviceCriacaoDto AddDevice(DeviceCriacaoDto device);
        void UpdateDevice(DeviceAtualizacaoDto device);
        void DeleteDevice(DeviceDto device);

        #endregion
    }
}