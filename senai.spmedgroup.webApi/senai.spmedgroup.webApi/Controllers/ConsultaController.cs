using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.spmedgroup.webApi.Domains;
using senai.spmedgroup.webApi.Interfaces;
using senai.spmedgroup.webApi.Repositories;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedgroup.webApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaController : ControllerBase
    {
        private IConsultaRepository _consultaRepository { get; set; }

        public ConsultaController()
        {
            _consultaRepository = new ConsultaRepository();
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_consultaRepository.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult ReadById(int id)
        {
            return Ok(_consultaRepository.BuscarPorId(id));
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Create(Consulta novaConsulta)
        {
            _consultaRepository.Cadastrar(novaConsulta);
            return StatusCode(200);
        }

        [Authorize(Roles = "1")]
        [HttpPut("{id}")]
        public IActionResult Put(int id, Consulta consultaAtualizada)
        {
            _consultaRepository.Atualizar(id, consultaAtualizada);
            return StatusCode(204);
        }

        [Authorize(Roles = "1,2")]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _consultaRepository.Deletar(id);
            return StatusCode(200);
        }

        [HttpGet("minhas")]
        public IActionResult GetMinha()
        {
            try
            {
              int  idUsuario = Convert.ToInt32(HttpContext.User.Claims.First(c => c.Type == JwtRegisteredClaimNames.Jti).Value);
                return Ok(_consultaRepository.ListarMinhas(idUsuario));
            }
            catch (Exception error)
            {
                // Retorna a resposta da requisição 400 - Bad Request e o erro ocorrido
                return BadRequest(new
                {
                    mensagem = "Não é possível mostrar as consultas se o usuário não estiver logado!",
                    error
                });
            }
        }
    }
}