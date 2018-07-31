using System;
using System.Collections.Generic;

namespace Dominio.Entidades
{
    public class Turma
    {
        public Turma()
        {
            this.Alunos = new List<Aluno>();
            this.Professores = new List<Professor>();
        }
        public int Id { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string Descricao { get; set; }
        public string Horario { get; set; }
        public DateTime DataCadastro { get; set; }
        public virtual ICollection<Aluno> Alunos { get; set; }
        public virtual ICollection<Professor> Professores { get; set; }
    }
}