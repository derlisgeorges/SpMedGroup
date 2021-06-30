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
    public class PacienteController : ControllerBase
    {
        private IPacienteRepository PacienteRepository { get; set; }
        public PacienteController()
        {
            PacienteRepository = new PacienteRepository();

        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(PacienteRepository.Listar());
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
                return Ok(PacienteRepository.BuscarPorId(id));
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [HttpPost]
        public IActionResult Post(Paciente novoPaciente)
        {
            try
            {
                PacienteRepository.Cadastrar(novoPaciente);
                return StatusCode(201);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }

        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Paciente PaceinteAtualizado)
        {
            try
            {
                PacienteRepository.Atualizar(id, PaceinteAtualizado);
                return StatusCode(204);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }


    }
}
