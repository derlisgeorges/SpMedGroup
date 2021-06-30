using senai.spmedgroup.webApi.Contexts;
using senai.spmedgroup.webApi.Domains;
using senai.spmedgroup.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedgroup.webApi.Repositories
{

    public class MedicoRepository : IMedicoRepository
    {
        SpMedGroupContext ctx = new SpMedGroupContext();


        public void Atualizar(int id, Medico MedicoAtualizado)
        {

            Medico MedicoAntigo = ctx.Medicos.Find(id);

            if (MedicoAtualizado.IdClinica != 0)
            {
                MedicoAntigo.IdClinica = MedicoAtualizado.IdClinica;
            }

            if (MedicoAtualizado.Crm != null)
            {
                MedicoAntigo.Crm = MedicoAtualizado.Crm;
            }

            if (MedicoAtualizado.IdUsuario != 0)
            {
                MedicoAntigo.IdUsuario = MedicoAtualizado.IdUsuario;
            }

            if (MedicoAtualizado.IdEspecialidade != 0)
            {
                MedicoAntigo.IdEspecialidade = MedicoAtualizado.IdEspecialidade;
            }

            if (MedicoAtualizado.NomeMedico != null)
            {
                MedicoAntigo.NomeMedico = MedicoAtualizado.NomeMedico;
            }

            ctx.Medicos.Update(MedicoAtualizado);


            ctx.SaveChanges();
        }


        public Medico BuscarPorId(int id)
        {

            return ctx.Medicos.FirstOrDefault(tu => tu.IdMedico == id);
        }


        public void Cadastrar(Medico novoMedico)
        {

            ctx.Medicos.Add(novoMedico);


            ctx.SaveChanges();
        }


        public void Deletar(int id)
        {

            Medico MedicoBuscado = ctx.Medicos.Find(id);


            ctx.Medicos.Remove(MedicoBuscado);

            ctx.SaveChanges();
        }

        public List<Medico> Listar()
        {

            return ctx.Medicos.ToList();
        }
    }
}
