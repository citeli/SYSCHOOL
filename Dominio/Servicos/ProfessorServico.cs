using Dominio.Entidades;
using Dominio.Interfaces.Repositorio;
using Dominio.Interfaces.Servico;

namespace Dominio.Servicos
{
    public class ProfessorServico : ServicoPadrao<Professor>, IProfessorServico
    {
        private readonly IProfessorRepositorio _professorRepositorio;

        public ProfessorServico(IProfessorRepositorio professorRepositorio) : base(professorRepositorio)
        {
            _professorRepositorio = professorRepositorio;
        }
    }
}
