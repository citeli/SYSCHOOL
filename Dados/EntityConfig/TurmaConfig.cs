using System.Data.Entity.ModelConfiguration;
using Dominio.Entidades;

namespace Dados.EntityConfig
{
    public class TurmaConfig : EntityTypeConfiguration<Turma>
    {
        public TurmaConfig()
        {
            ToTable("Turmas");
            Property(turma => turma.Descricao).HasColumnType("varchar").IsRequired();
            Property(turma => turma.DataCadastro).HasColumnType("datetime").IsRequired();
            Property(turma => turma.DataInicio).HasColumnType("datetime").IsRequired();
            Property(turma => turma.DataFim).HasColumnType("datetime").IsOptional();
            Property(turma => turma.Horario).HasColumnType("varchar").IsRequired();
        }
    }
}