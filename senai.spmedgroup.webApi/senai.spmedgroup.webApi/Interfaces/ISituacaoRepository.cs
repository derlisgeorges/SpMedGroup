using senai.spmedgroup.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedgroup.webApi.Interfaces
{
    interface ISituacaoRepository
    {

        List<Situacao> Listar();

        Situacao BuscarPorId(int id);

        void Cadastrar(Situacao novaSituacao);

        void Atualizar(int id, Situacao situacaoAtualizada);

        void Deletar(int id);
    }
}
