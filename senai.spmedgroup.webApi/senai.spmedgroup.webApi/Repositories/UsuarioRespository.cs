using senai.spmedgroup.webApi.Contexts;
using senai.spmedgroup.webApi.Domains;
using senai.spmedgroup.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedgroup.webApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {

        SpMedGroupContext ctx = new SpMedGroupContext();

        public void Atualizar(int id, Usuario UsuarioAtualizado)
        {
            Usuario UsuarioAntigo = BuscarPorId(id);

            if (UsuarioAtualizado.Email != null)
            {
                UsuarioAntigo.Email = UsuarioAtualizado.Email;
            }

            if (UsuarioAtualizado.Senha != null)
            {
                UsuarioAntigo.Senha = UsuarioAtualizado.Senha;
            }

            if (UsuarioAtualizado.IdTipoUsuario != null)
            {
                UsuarioAntigo.IdTipoUsuario = UsuarioAtualizado.IdTipoUsuario;
            }

            ctx.Usuarios.Update(UsuarioAntigo);

            ctx.SaveChanges();

        }

        public Usuario BuscarPorId(int id)
        {
            return ctx.Usuarios.Find(id);
        }

        public void Cadastrar(Usuario novoUsuario)
        {
            ctx.Usuarios.Add(novoUsuario);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.Usuarios.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }

        public List<Usuario> Listar()
        {
            return ctx.Usuarios.ToList();
        }

        public Usuario Login(string email, string senha)
        {
            return ctx.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }
    }
}
