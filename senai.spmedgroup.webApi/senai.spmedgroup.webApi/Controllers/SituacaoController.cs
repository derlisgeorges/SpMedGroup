using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.spmedgroup.webApi.Domains;
using senai.spmedgroup.webApi.Interfaces;
using senai.spmedgroup.webApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedgroup.webApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class SituacaoController : ControllerBase
    {
        private ISituacaoRepository SituacaoRepository { get; set; }
        public SituacaoController()
        {
            SituacaoRepository = new SituacaoRepository();

        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {

                return Ok(SituacaoRepository.Listar());
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(SituacaoRepository.BuscarPorId(id));
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [HttpPost]
        public IActionResult Post(Situacao novaSituacao)
        {
            try
            {
                SituacaoRepository.Cadastrar(novaSituacao);

                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Situacao SituacaoAtualizada)
        {
            try
            {
                SituacaoRepository.Atualizar(id, SituacaoAtualizada);

                return StatusCode(204);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }


        }
    }
}
