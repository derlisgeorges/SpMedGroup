using senai.spmedgroup.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedgroup.webApi.Interfaces
{
    interface IUsuarioRepository
    {

        List<Usuario> Listar();

        Usuario BuscarPorId(int id);

        void Cadastrar(Usuario novoUsuario);

        void Atualizar(int id, Usuario UsuarioAtualizado);

        void Deletar(int id);

        Usuario Login(string email, string senha);
    }
}
