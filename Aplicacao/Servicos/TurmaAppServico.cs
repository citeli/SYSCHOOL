using Aplicacao.Interfaces;
using Dominio.Entidades;
using Dominio.Interfaces.Servico;

namespace Aplicacao.Servicos
{
    public class TurmaAppServico : AppServicoPadrao<Turma>, IAppTurmaServico
    {
        private readonly ITurmaServico _turmaServico;

        public TurmaAppServico(ITurmaServico turmaServico) : base(turmaServico)
        {
            _turmaServico = turmaServico;
        }
    }
}