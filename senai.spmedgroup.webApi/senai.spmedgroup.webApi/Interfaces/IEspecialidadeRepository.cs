using senai.spmedgroup.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedgroup.webApi.Interfaces
{
    interface IEspecialidadeRepository
    {

        List<Especialidade> Listar();

        Especialidade BuscarPorId(int id);

        void Cadastrar(Especialidade novaEspecialidade);

        void Atualizar(int id, Especialidade EspecialidadeAtualizada);

        void Deletar(int id);
    }
}
