using System.Collections.Generic;

namespace Dominio.Entidades
{
    public class Professor : Pessoa
    {
        public Professor()
        {
            this.Turmas = new List<Turma>();
        }
        public int Id { get; set; }
        public ICollection<Turma> Turmas { get; set; }
    }
}