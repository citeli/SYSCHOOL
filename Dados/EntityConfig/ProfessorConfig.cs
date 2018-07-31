using System.Data.Entity.ModelConfiguration;
using Dominio.Entidades;

namespace Dados.EntityConfig
{
    public class ProfessorConfig : EntityTypeConfiguration<Professor>
    {
        public ProfessorConfig()
        {
            ToTable("Professores");
            Property(professor => professor.Nome).HasMaxLength(50).IsRequired();
            Property(professor => professor.SobreNome).HasMaxLength(50).IsRequired();
            Property(professor => professor.DataNascimento).HasColumnType("datetime").IsRequired();
            Property(professor => professor.DataCadastro).HasColumnType("datetime").IsRequired();
            Property(professor => professor.Cpf).HasMaxLength(23).IsRequired();
            Property(professor => professor.Rg).HasMaxLength(12).IsRequired();
            Property(professor => professor.Email).HasMaxLength(80).IsRequired();
            Property(professor => professor.Endereco).HasMaxLength(200).IsOptional();
            Property(professor => professor.NumeroTelefone).HasMaxLength(12).IsOptional();
            Property(professor => professor.NumeroCelular).HasMaxLength(14).IsOptional();

            HasMany(professor => professor.Turmas)
                .WithMany(tp => tp.Professores)
                .Map(tp =>
                {
                    tp.ToTable("TurmaProfessor");
                    tp.MapLeftKey("ProfessorId");
                    tp.MapRightKey("TurmaId");
                });
        }
    }
}