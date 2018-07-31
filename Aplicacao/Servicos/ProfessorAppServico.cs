using Aplicacao.Interfaces;
using Dominio.Entidades;
using Dominio.Interfaces.Servico;

namespace Aplicacao.Servicos
{
    public class ProfessorAppServico : AppServicoPadrao<Professor>, IAppProfessorServico
    {
        private readonly IProfessorServico _professorServico;

        public ProfessorAppServico(IProfessorServico professorServico) : base(professorServico)
        {
            _professorServico = professorServico;
        }
    }
}
