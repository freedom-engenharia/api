using AutomacaoFreedom.Modelo.Tipologia;
using AutomacaoFreedom.Modelos.Tipologia;
using AutomacaoFreedomApi.Aplicacao.Interface;
using AutomacaoFreedomApi.Repositorios;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AutomacaoFreedomApi.Controlador.Tipologia
{
    [Route("api/Tipologia/Local")]
    [ApiController]
    public class LocalControlador : ControllerBase
    {

        private readonly ITipologiaAplicacao _tipologiaAplicacao;
        private readonly IAutomacaoFreedomUnitOfWork _automacaoFreedomUnitOfWork;

        public LocalControlador(ITipologiaAplicacao tipologiaAplicacao, IAutomacaoFreedomUnitOfWork automacaoFreedomUnitOfWork)
        {
            _tipologiaAplicacao = tipologiaAplicacao;
            _automacaoFreedomUnitOfWork = automacaoFreedomUnitOfWork;
        }

        [HttpGet(Name = "GetLocals")]
        public IActionResult GetLocals()
        {
            return Ok(_tipologiaAplicacao.GetLocais());
        }

        [HttpGet("{id}", Name = "GetLocal")]
        public ActionResult<LocalDto> GetLocal(Guid id)
        {
            var local = _tipologiaAplicacao.GetLocalById(id);
            if (local == null)
                return NotFound();
            return local;
        }

        [HttpPost(Name = "CreateLocal")]
        public IActionResult CreateLocal([FromBody] LocalCreacaoDto local)
        {
            var creacao = _tipologiaAplicacao.AddLocal(local);
            _automacaoFreedomUnitOfWork.Save();
            return CreatedAtRoute("GetLocal", new { id = creacao.Id }, creacao);
        }

        [HttpPut("{id}", Name = "UpdateLocal")]
        public IActionResult Update(Guid id, LocalAtuazacaoDto local)
        {
            _tipologiaAplicacao.UpdateLocal(local);
            _automacaoFreedomUnitOfWork.Save();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var local = _tipologiaAplicacao.GetLocalById(id);
            _tipologiaAplicacao.DeleteLocal(local);
            _automacaoFreedomUnitOfWork.Save();
            return NoContent();
        }

    }
}