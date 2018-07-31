using Aplicacao.Interfaces;
using Dominio.Entidades;
using Dominio.Interfaces.Servico;

namespace Aplicacao.Servicos
{
    public class AlunoAppServico : AppServicoPadrao<Aluno>, IAppAlunoServico
    {
        private readonly IAlunoServico _alunoServico;

        public AlunoAppServico(IAlunoServico alunoServico) : base(alunoServico)
        {
            _alunoServico = alunoServico;
        }
    }
}
