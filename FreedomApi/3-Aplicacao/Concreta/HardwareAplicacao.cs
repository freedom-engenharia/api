
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

        public string LigarDevice(string iP) =>
            _deviceServico.LigarDevice(iP);

        public string DesligarDevice(string iP) =>
           _deviceServico.DesligarDevice(iP);

        public string AtualuAtualizarStatusDevice(string iP, int status, string dataModificacao)
        {
            DateTime data = stringConfiguracao.converteStringEmDataTime(dataModificacao);

            var device = _deviceServico.GetByIP(iP);

            if (device.DataModificacao > data)
            {
                if (status == 1 && device.Status == Infraestrutura.Enum.DeviceStatus.LIGADO ||
                    status == 0 && device.Status == Infraestrutura.Enum.DeviceStatus.DESLIGADO)
                {
                    return "Dispositivo já esta atualizado";
                }
                if (status == 1 && device.Status == Infraestrutura.Enum.DeviceStatus.DESLIGADO)
                {
                    DesligarDevice(iP);
                    return "Dispositivo atualizado (Desligado)";
                }
                if (status == 0 && device.Status == Infraestrutura.Enum.DeviceStatus.LIGADO)
                {
                    LigarDevice(iP);
                    return "Dispositivo atualizado (Ligado)";
                }

            }
            else if (device.DataModificacao < data)
            {
                if (status == 1)
                {
                    device.Status = Infraestrutura.Enum.DeviceStatus.LIGADO;
                    return "BD atualizado, disposito ligado";
                }
                else
                {
                    device.Status = Infraestrutura.Enum.DeviceStatus.DESLIGADO;
                    return "BD atualizado, disposito desligado";
                }
            }
            return "ok";
        }

        #endregion
    }
}