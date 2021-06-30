using senai.spmedgroup.webApi.Contexts;
using senai.spmedgroup.webApi.Domains;
using senai.spmedgroup.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedgroup.webApi.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {

        SpMedGroupContext ctx = new SpMedGroupContext();

        public void Atualizar(int id, TiposUsuario tipoUsuarioAtualizado)
        {

            TiposUsuario tipoUsuarioBuscado = ctx.TiposUsuarios.Find(id);


            if (tipoUsuarioAtualizado.TituloTipoUsuario != null)
            {

                tipoUsuarioBuscado.TituloTipoUsuario = tipoUsuarioAtualizado.TituloTipoUsuario;
            }


            ctx.TiposUsuarios.Update(tipoUsuarioBuscado);


            ctx.SaveChanges();
        }


        public TiposUsuario BuscarPorId(int id)
        {

            return ctx.TiposUsuarios.FirstOrDefault(tu => tu.IdTipoUsuario == id);
        }


        public void Cadastrar(TiposUsuario novoTipoUsuario)
        {

            ctx.TiposUsuarios.Add(novoTipoUsuario);


            ctx.SaveChanges();
        }


        public void Deletar(int id)
        {

            TiposUsuario tipoUsuarioBuscado = ctx.TiposUsuarios.Find(id);


            ctx.TiposUsuarios.Remove(tipoUsuarioBuscado);


            ctx.SaveChanges();
        }


        public List<TiposUsuario> Listar()
        {

            return ctx.TiposUsuarios.ToList();
        }
    }
}
