using senai.spmedgroup.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedgroup.webApi.Interfaces
{
    interface IConsultaRepository
    {

        List<Consulta> Listar();

        Consulta BuscarPorId(int id);

        void Cadastrar(Consulta novaConsulta);

        void Atualizar(int id, Consulta consultaAtualizada);

        void Deletar(int id);

        void NovaAtualizacao(int id, string Descricaoatulizada);

        void NovaDescricao(int id, string statusAtualizado);

        List<Consulta> ListarMinhas(int id);
    }
}
