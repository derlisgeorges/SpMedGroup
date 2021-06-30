using senai.spmedgroup.webApi.Contexts;
using senai.spmedgroup.webApi.Domains;
using senai.spmedgroup.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedgroup.webApi.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        SpMedGroupContext ctx = new SpMedGroupContext();


        public void Atualizar(int id, Paciente PacienteAtualizado)
        {
            Paciente PacienteAntigo = ctx.Pacientes.Find(id);

            if (PacienteAtualizado.IdUsuario != 0)
            {
                PacienteAntigo.IdUsuario = PacienteAtualizado.IdUsuario;
            }

            if (PacienteAtualizado.Nome != null)
            {
                PacienteAntigo.Nome = PacienteAtualizado.Nome;
            }

            if (PacienteAtualizado.DataNascimento != null)
            {
                PacienteAntigo.DataNascimento = PacienteAtualizado.DataNascimento;
            }

            if (PacienteAtualizado.Telefone != null)
            {
                PacienteAntigo.Telefone = PacienteAtualizado.Telefone;
            }

            if (PacienteAtualizado.Rg != null)
            {
                PacienteAntigo.Rg = PacienteAtualizado.Rg;
            }

            if (PacienteAtualizado.Cpf != null)
            {
                PacienteAntigo.Cpf = PacienteAtualizado.Cpf;
            }

            if (PacienteAtualizado.Endereco != null)
            {
                PacienteAntigo.Endereco = PacienteAtualizado.Endereco;
            }



            ctx.Pacientes.Update(PacienteAtualizado);


            ctx.SaveChanges();
        }


        public Paciente BuscarPorId(int id)
        {

            return ctx.Pacientes.FirstOrDefault(tu => tu.IdPaciente == id);
        }


        public void Cadastrar(Paciente novoPaciente)
        {

            ctx.Pacientes.Add(novoPaciente);


            ctx.SaveChanges();
        }


        public void Deletar(int id)
        {

            Paciente PacienteBuscado = ctx.Pacientes.Find(id);


            ctx.Pacientes.Remove(PacienteBuscado);

            ctx.SaveChanges();
        }

        public List<Paciente> Listar()
        {

            return ctx.Pacientes.ToList();
        }
    }
}
