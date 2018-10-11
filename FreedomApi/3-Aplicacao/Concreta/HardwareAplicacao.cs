
using AutomacaoFreedomApi.Aplicacao.Interface;
using AutomacaoFreedomApi.Infraestrutura.Util;
using AutomacaoFreedomApi.Modelo.Hardware;
using AutomacaoFreedomApi.Servico.Hardware.Interface;
using AutoMapper;
using System;
using System.Collections.Generic;

namespace AutomacaoFreedomApi.Aplicacao.Concreta
{
    public class HardwareAplicacao : IHardwareAplicacao
    {
        private readonly IDeviceServico _deviceServico;
        StringConfiguracao stringConfiguracao = new StringConfiguracao();

        public HardwareAplicacao(IDeviceServico deviceServico)
        {

            _deviceServico = deviceServico;

        }
        #region Device

        public IEnumerable<DeviceDto> GetDevices() =>
           Mapper.Map<IEnumerable<DeviceDto>>(_deviceServico.GetAll());

        public DeviceDto GetDeviceById(Guid id) =>
             _deviceServico.GetById(id);

        public DeviceCriacaoDto AddDevice(DeviceCriacaoDto device) =>
            _deviceServico.Add(device);

        public void UpdateDevice(DeviceAtualizacaoDto device) =>
            _deviceServico.Update(device);

        public void DeleteDevice(DeviceDto device) =>
            _deviceServico.Delete(device);

        #endregion
    }
}