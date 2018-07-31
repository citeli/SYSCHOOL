using Dominio.Entidades;
using Dominio.Interfaces.Repositorio;
using Dominio.Interfaces.Servico;

namespace Dominio.Servicos
{
    public class TurmaServico : ServicoPadrao<Turma>, ITurmaServico
    {
        private readonly ITurmaRepositorio _turmaRepositorio;

        public TurmaServico(ITurmaRepositorio turmaRepositorio) : base(turmaRepositorio)
        {
            _turmaRepositorio = turmaRepositorio;
        }
    }
}