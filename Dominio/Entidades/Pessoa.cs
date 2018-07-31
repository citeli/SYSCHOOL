using System;

namespace Dominio.Entidades
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string NumeroTelefone { get; set; }
        public string NumeroCelular { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Endereco { get; set; }
    }
}