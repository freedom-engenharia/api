
using AutomacaoFreedom.Modelo.Tipologia;
using AutomacaoFreedom.Modelos.Tipologia;
using AutomacaoFreedomApi.Aplicacao.Interface;
using AutomacaoFreedomApi.Repositorios;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AutomacaoFreedomApi.Controlador.Tipologia
{
    [Route("api/Tipologia/SubLocal")]
    [ApiController]
    public class SubLocalControlador : ControllerBase
    {

        private readonly ITipologiaAplicacao _tipologiaAplicacao;
        private readonly IAutomacaoFreedomUnitOfWork _automacaoFreedomUnitOfWork;

        public SubLocalControlador(ITipologiaAplicacao tipologiaAplicacao, IAutomacaoFreedomUnitOfWork automacaoFreedomUnitOfWork)
        {
            _tipologiaAplicacao = tipologiaAplicacao;
            _automacaoFreedomUnitOfWork = automacaoFreedomUnitOfWork;
        }

        [HttpGet(Name = "GetSubLocais")]
        public IActionResult GetSubLocais()
        {
            return Ok(_tipologiaAplicacao.GetSubLocais());
        }

        [HttpGet("{id}", Name = "GetSubLocal")]
        public ActionResult<SubLocalDto> GetSubLocal(Guid id)
        {
            var subLocal = _tipologiaAplicacao.GetSubLocalById(id);
            if (subLocal == null)
                return NotFound();
            return subLocal;
        }

        [HttpPost(Name = "CreateSubLocal")]
        public IActionResult CreateSubLocal([FromBody] SubLocalCreacaoDto subLocal)
        {
            var creacao = _tipologiaAplicacao.AddSubLocal(subLocal);
            _automacaoFreedomUnitOfWork.Save();
            return CreatedAtRoute("GetSubLocal", new { id = creacao.Id }, creacao);
        }

        [HttpPut("{id}", Name = "UpdateSubLocal")]
        public IActionResult Update(Guid id, SubLocalAtualizacaoDto subLocal)
        {
            _tipologiaAplicacao.UpdateSubLocal(subLocal);
            _automacaoFreedomUnitOfWork.Save();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var subLocal = _tipologiaAplicacao.GetSubLocalById(id);
            _tipologiaAplicacao.DeleteSubLocal(subLocal);
            _automacaoFreedomUnitOfWork.Save();
            return NoContent();
        }

    }
}