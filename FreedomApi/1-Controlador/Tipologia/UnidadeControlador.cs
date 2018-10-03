
using AutomacaoFreedom.Entidades.Tipologia;
using AutomacaoFreedom.Modelo.Tipologia;
using AutomacaoFreedomApi.Aplicacao.Interface;
using AutomacaoFreedomApi.Repositorios;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AutomacaoFreedomApi.Controlador.Tipologia
{
    [Route("api/Tipologia/Unidade")]
    [ApiController]
    public class UnidadeControlador : ControllerBase
    {

        private readonly ITipologiaAplicacao _tipologiaAplicacao;
        private readonly IAutomacaoFreedomUnitOfWork _automacaoFreedomUnitOfWork;

        public UnidadeControlador(ITipologiaAplicacao tipologiaAplicacao, IAutomacaoFreedomUnitOfWork automacaoFreedomUnitOfWork)
        {
            _tipologiaAplicacao = tipologiaAplicacao;
            _automacaoFreedomUnitOfWork = automacaoFreedomUnitOfWork;
        }

        [HttpGet(Name = "GetUnidades")]
        public IActionResult GetUnidades()
        {
            return Ok(_tipologiaAplicacao.GetUnidades());
        }

        [HttpGet("{id}", Name = "GetUnidade")]
        public ActionResult<UnidadeDto> GetUnidade(Guid id)
        {
            var unidade = _tipologiaAplicacao.GetUnidadeById(id);
            if (unidade == null)
                return NotFound();
            return unidade;
        }

        [HttpPost(Name = "CreateUnidade")]
        public IActionResult CreateUnidade([FromBody] UnidadeCriacaoDto unidade)
        {
            var creacao = _tipologiaAplicacao.AddUnidade(unidade);
            _automacaoFreedomUnitOfWork.Save();
            return CreatedAtRoute("GetUnidade", new { id = creacao.Id }, creacao);
        }

        [HttpPut("{id}", Name = "UpdateUnidade")]
        public IActionResult Update(Guid id, UnidadeAtualizacaoDto unidade)
        {
            _tipologiaAplicacao.UpdateUnidade(unidade);
            _automacaoFreedomUnitOfWork.Save();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var unidade = _tipologiaAplicacao.GetUnidadeById(id);
            _tipologiaAplicacao.DeleteUnidade(unidade);
            _automacaoFreedomUnitOfWork.Save();
            return NoContent();
        }

    }
}