
using AutomacaoFreedomApi.Aplicacao.Interface;
using AutomacaoFreedomApi.Modelo.Tipologia;
using AutomacaoFreedomApi.Repositorios;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AutomacaoFreedomApi.Controlador.Tipologia
{
    [Route("api/Tipologia/Empresa")]
    [ApiController]
    public class EmpresaControlador : ControllerBase
    {

        private readonly ITipologiaAplicacao _tipologiaAplicacao;
        private readonly IAutomacaoFreedomUnitOfWork _automacaoFreedomUnitOfWork;

        public EmpresaControlador(ITipologiaAplicacao tipologiaAplicacao, IAutomacaoFreedomUnitOfWork automacaoFreedomUnitOfWork)
        {
            _tipologiaAplicacao = tipologiaAplicacao;
            _automacaoFreedomUnitOfWork = automacaoFreedomUnitOfWork;
        }

        [HttpGet(Name = "GetEmpresas")]
        public IActionResult GetEmpresas()
        {
            return Ok(_tipologiaAplicacao.GetEmpresas());
        }

        [HttpGet("{id}", Name = "GetEmpresa")]
        public ActionResult<EmpresaDto> GetEmpresa(Guid id)
        {
            var empresa = _tipologiaAplicacao.GetEmpresaById(id);
            if (empresa == null)
                return NotFound();
            return empresa;
        }

        [HttpPost(Name = "CreateEmpresa")]
        public IActionResult CreateEmpresa([FromBody] EmpresaDto empresa)
        {
            var creacao = _tipologiaAplicacao.AddEmpresa(empresa);
            _automacaoFreedomUnitOfWork.Save();
            return CreatedAtRoute("GetEmpresa", new { id = creacao.Id }, creacao);
        }

        [HttpPut("{id}", Name = "UpdateEmpresa")]
        public IActionResult Update(Guid id, EmpresaDto empresa)
        {
            _tipologiaAplicacao.UpdateEmpresa(empresa);
            _automacaoFreedomUnitOfWork.Save();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var empresa = _tipologiaAplicacao.GetEmpresaById(id);
            _tipologiaAplicacao.DeleteEmpresa(empresa);
            _automacaoFreedomUnitOfWork.Save();
            return NoContent();
        }

    }
}