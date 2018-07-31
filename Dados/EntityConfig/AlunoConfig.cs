using System.Data.Entity.ModelConfiguration;
using Dominio.Entidades;

namespace Dados.EntityConfig
{
    public class AlunoConfig : EntityTypeConfiguration<Aluno>
    {
        public AlunoConfig()
        {
            ToTable("Alunos");
            Property(aluno => aluno.Matricula).HasMaxLength(9).IsRequired();
            Property(aluno => aluno.Nome).HasMaxLength(50).IsRequired();
            Property(aluno => aluno.SobreNome).HasMaxLength(50).IsRequired();
            Property(aluno => aluno.DataNascimento).HasColumnType("datetime").IsRequired();
            Property(aluno => aluno.DataCadastro).HasColumnType("datetime").IsRequired();
            Property(aluno => aluno.Cpf).HasMaxLength(23).IsRequired();
            Property(aluno => aluno.Rg).HasMaxLength(12).IsRequired();
            Property(aluno => aluno.Email).HasMaxLength(80).IsRequired();
            Property(aluno => aluno.Endereco).HasMaxLength(200).IsOptional();
            Property(aluno => aluno.NumeroTelefone).HasMaxLength(12).IsOptional();
            Property(aluno => aluno.NumeroCelular).HasMaxLength(14).IsOptional();

            HasMany(aluno => aluno.Turmas)
                .WithMany(turma => turma.Alunos)
                .Map(at =>
                {
                    at.ToTable("AlunoTurma");
                    at.MapLeftKey("AlunoId");
                    at.MapRightKey("TurmaId");
                });
        }
    }
}