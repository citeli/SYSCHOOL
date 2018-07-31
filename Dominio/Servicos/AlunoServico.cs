using Dominio.Entidades;
using Dominio.Interfaces.Repositorio;
using Dominio.Interfaces.Servico;

namespace Dominio.Servicos
{
    public class AlunoServico : ServicoPadrao<Aluno>, IAlunoServico
    {
        private readonly IAlunoRepositorio _alunoRepositorio;

        public AlunoServico(IAlunoRepositorio alunoRepositorio) : base(alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
        }
    }
}
