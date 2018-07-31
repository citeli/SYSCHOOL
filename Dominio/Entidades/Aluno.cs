using System.Collections.Generic;

namespace Dominio.Entidades
{
    public class Aluno : Pessoa
    {
        public Aluno()
        {
            this.Turmas = new List<Turma>();
        }
        public int Id { get; set; }
        public string Matricula { get; set; }
        public virtual ICollection<Turma> Turmas { get; set; }
    }
}