
using AutomacaoFreedomApi.Entidade.Hardware;
using AutomacaoFreedomApi.Infraestrutura.Util;
using AutomacaoFreedomApi.Modelo.Hardware;
using AutomacaoFreedomApi.Repositorios.Hardware.Interface;
using AutomacaoFreedomApi.Servico.Hardware.Interface;
using AutoMapper;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace AutomacaoFreedomApi.Servico.Hardware.Concreta
{
    public class DeviceServico : IDeviceServico
    {
        private readonly IDeviceRepositorio _repositorio;
        private readonly HttpClient _httpClient;
        StringConfiguracao dataTime = new StringConfiguracao();

        public DeviceServico(IDeviceRepositorio repositorio)
        {
            _repositorio = repositorio;
            _httpClient = new HttpClient();
        }

        public IQueryable<Device> GetAll()
        {
            var query = _repositorio.GetAll();
            return query;

        }

        public DeviceDto GetById(Guid id)
        {
            var Device = _repositorio.GetById(id);
            var byDevice = Mapper.Map<DeviceDto>(Device);
            return byDevice;
        }

        public DeviceCriacaoDto Add(DeviceCriacaoDto Device)
        {
            var novoDevice = Mapper.Map<Device>(Device);
            var creado = _repositorio.Add(novoDevice);
            var entidade = Mapper.Map<DeviceCriacaoDto>(creado);
            return entidade;
        }

        public void Update(DeviceAtualizacaoDto Device) =>
            _repositorio.Update(Mapper.Map<Device>(Device));

        public void Delete(DeviceDto Device) =>
           _repositorio.Delete(Mapper.Map<Device>(Device));

        public DeviceDto GetByIP(string iP) =>
           Mapper.Map<DeviceDto>(_repositorio.GetByIP(iP));

        public string LigarDevice(string iP) {
            var device = _repositorio.GetByIP(iP);

            device.DataModificacao = DateTime.Now;

            device.Status = Infraestrutura.Enum.DeviceStatus.LIGADO;

            _repositorio.Update(device);

             var resposta = _httpClient.GetStringAsync("http://"+ iP +"/" + DateTime.Now +"/on").Result;

            return resposta;
        }

        public  string DesligarDevice(string iP)
        {
            var device = _repositorio.GetByIP(iP);

            device.DataModificacao = DateTime.Now;

            device.Status = Infraestrutura.Enum.DeviceStatus.DESLIGADO;

            _repositorio.Update(device);

            var resposta = _httpClient.GetStringAsync("http://" + iP + "/" + DateTime.Now + "/off").Result;

            return resposta;

        }

    }
}
