namespace Dados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alunos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Matricula = c.String(nullable: false, maxLength: 9, unicode: false),
                        Nome = c.String(nullable: false, maxLength: 50, unicode: false),
                        SobreNome = c.String(nullable: false, maxLength: 50, unicode: false),
                        Cpf = c.String(nullable: false, maxLength: 23, unicode: false),
                        Rg = c.String(nullable: false, maxLength: 12, unicode: false),
                        DataNascimento = c.DateTime(nullable: false),
                        Email = c.String(nullable: false, maxLength: 80, unicode: false),
                        NumeroTelefone = c.String(maxLength: 12, unicode: false),
                        NumeroCelular = c.String(maxLength: 14, unicode: false),
                        DataCadastro = c.DateTime(nullable: false),
                        Endereco = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Turmas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataInicio = c.DateTime(nullable: false),
                        DataFim = c.DateTime(),
                        Descricao = c.String(nullable: false, maxLength: 100, unicode: false),
                        Horario = c.String(nullable: false, maxLength: 100, unicode: false),
                        DataCadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Professores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50, unicode: false),
                        SobreNome = c.String(nullable: false, maxLength: 50, unicode: false),
                        Cpf = c.String(nullable: false, maxLength: 23, unicode: false),
                        Rg = c.String(nullable: false, maxLength: 12, unicode: false),
                        DataNascimento = c.DateTime(nullable: false),
                        Email = c.String(nullable: false, maxLength: 80, unicode: false),
                        NumeroTelefone = c.String(maxLength: 12, unicode: false),
                        NumeroCelular = c.String(maxLength: 14, unicode: false),
                        DataCadastro = c.DateTime(nullable: false),
                        Endereco = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TurmaProfessor",
                c => new
                    {
                        ProfessorId = c.Int(nullable: false),
                        TurmaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProfessorId, t.TurmaId })
                .ForeignKey("dbo.Professores", t => t.ProfessorId)
                .ForeignKey("dbo.Turmas", t => t.TurmaId)
                .Index(t => t.ProfessorId)
                .Index(t => t.TurmaId);
            
            CreateTable(
                "dbo.AlunoTurma",
                c => new
                    {
                        AlunoId = c.Int(nullable: false),
                        TurmaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AlunoId, t.TurmaId })
                .ForeignKey("dbo.Alunos", t => t.AlunoId)
                .ForeignKey("dbo.Turmas", t => t.TurmaId)
                .Index(t => t.AlunoId)
                .Index(t => t.TurmaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AlunoTurma", "TurmaId", "dbo.Turmas");
            DropForeignKey("dbo.AlunoTurma", "AlunoId", "dbo.Alunos");
            DropForeignKey("dbo.TurmaProfessor", "TurmaId", "dbo.Turmas");
            DropForeignKey("dbo.TurmaProfessor", "ProfessorId", "dbo.Professores");
            DropIndex("dbo.AlunoTurma", new[] { "TurmaId" });
            DropIndex("dbo.AlunoTurma", new[] { "AlunoId" });
            DropIndex("dbo.TurmaProfessor", new[] { "TurmaId" });
            DropIndex("dbo.TurmaProfessor", new[] { "ProfessorId" });
            DropTable("dbo.AlunoTurma");
            DropTable("dbo.TurmaProfessor");
            DropTable("dbo.Professores");
            DropTable("dbo.Turmas");
            DropTable("dbo.Alunos");
        }
    }
}
