using AutomacaoFreedomApi.Aplicacao.Interface;
using AutomacaoFreedomApi.Modelo.Hardware;
using AutomacaoFreedomApi.Repositorios;
using AutomacaoFreedomApi.Servico.Hardware.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using static uPLibrary.Networking.M2Mqtt.MqttClient;

namespace AutomacaoFreedomApi.Controlador.Hardware
{
    [Route("api/Hardware/Device")]
    [ApiController]
    public class DeviceControlador : ControllerBase
    {

        private readonly IHardwareAplicacao _hardwareAplicacao;
        private readonly IAutomacaoFreedomUnitOfWork _automacaoFreedomUnitOfWork;
        private readonly IMqttServico _mqttServico;

        public DeviceControlador(IMqttServico mqttServico, IHardwareAplicacao hardwareAplicacao, IAutomacaoFreedomUnitOfWork automacaoFreedomUnitOfWork)
        {
            _hardwareAplicacao = hardwareAplicacao;
            _automacaoFreedomUnitOfWork = automacaoFreedomUnitOfWork;
            _mqttServico = mqttServico;

        }

        [HttpGet("MQTTLIGALED", Name = "MQTTLIGALED")]
        public IActionResult MQTTLIGALED()
        {
            _mqttServico.Publish("FREEDOMLED01", 1);
            return Ok("lIGADO VIA MQTT");
        }

        [HttpGet("MQTTDESLOGALED", Name = "MQTTDESLOGALED")]
        public IActionResult MQTTDESLOGALED()
        {
            _mqttServico.Publish("FREEDOMLED01", 0);
            return Ok("DESLIGADO VIA MQTT");
        }

        [HttpGet(Name = "GetDevices")]
        public IActionResult GetDevices()
        {
            return Ok(_hardwareAplicacao.GetDevices());
        }

        [HttpGet("{id}", Name = "GetDevice")]
        public ActionResult<DeviceDto> GetDevice(Guid id)
        {
            var device = _hardwareAplicacao.GetDeviceById(id);
            if (device == null)
                return NotFound();
            return device;
        }

        [HttpPost(Name = "CreateDevice")]
        public IActionResult CreateDevice([FromBody] DeviceCriacaoDto device)
        {
            var creacao = _hardwareAplicacao.AddDevice(device);
            _automacaoFreedomUnitOfWork.Save();
            return CreatedAtRoute("GetDevice", new { id = creacao.Id }, creacao);
        }

        [HttpPut("{id}", Name = "UpdateDevice")]
        public IActionResult Update(Guid id, DeviceAtualizacaoDto device)
        {
            _hardwareAplicacao.UpdateDevice(device);
            _automacaoFreedomUnitOfWork.Save();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var device = _hardwareAplicacao.GetDeviceById(id);
            _hardwareAplicacao.DeleteDevice(device);
            _automacaoFreedomUnitOfWork.Save();
            return NoContent();
        }

        [HttpGet("LigarDevice/{iP}", Name = "LigarDevice")]
        public IActionResult LigarDevice(string iP)
        {
            var resposta = _hardwareAplicacao.LigarDevice(iP);
            _automacaoFreedomUnitOfWork.Save();
            return Ok(resposta);
        }

        [HttpGet("DesligarDevice/{iP}", Name = "DesligarDevice")]
        public IActionResult DesligarDevice(string iP)
        {
            var resposta = _hardwareAplicacao.DesligarDevice(iP);
            _automacaoFreedomUnitOfWork.Save();
            return Ok(resposta);
        }

        [HttpGet("AtualizaStatus/{iP}/{status}/{DataModificacao}", Name = "AtualizarStatusDevice")]
        public IActionResult AtualizarStatusDevice(string iP, int status, string dataModificacao)
        {
            var resposta = _hardwareAplicacao.AtualuAtualizarStatusDevice(iP, status, dataModificacao);

            _automacaoFreedomUnitOfWork.Save();
            return Ok(resposta);
        }

    }
}