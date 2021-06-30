using senai.spmedgroup.webApi.Contexts;
using senai.spmedgroup.webApi.Domains;
using senai.spmedgroup.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedgroup.webApi.Repositories
{
    public class ClinicaRepository : IClinicaRepository
    {
        SpMedGroupContext ctx = new SpMedGroupContext();

        public void Atualizar(int id, Clinica ClinicaAtualizado)
        {
            Clinica ClinicaBuscada = BuscarPorId(id);

            if (ClinicaAtualizado.Cnpj != null)
            {
                ClinicaBuscada.Cnpj = ClinicaAtualizado.Cnpj;
            }

            if (ClinicaAtualizado.Endereco != null)
            {
                ClinicaBuscada.Endereco = ClinicaAtualizado.Endereco;
            }

            if (ClinicaAtualizado.NomeFantasia != null)
            {
                ClinicaBuscada.NomeFantasia = ClinicaAtualizado.NomeFantasia;
            }

            if (ClinicaAtualizado.RazaoSocial != null)
            {
                ClinicaBuscada.RazaoSocial = ClinicaAtualizado.RazaoSocial;
            }

            ctx.Clinicas.Update(ClinicaBuscada);

            ctx.SaveChanges();
        }

        public Clinica BuscarPorId(int id)
        {
            return ctx.Clinicas.Find(id);
        }

        public void Cadastrar(Clinica novaClinica)
        {
            ctx.Clinicas.Add(novaClinica);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.Clinicas.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }

        public List<Clinica> Listar()
        {
            return ctx.Clinicas.ToList();
        }
    }
}
