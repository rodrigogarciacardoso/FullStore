using System;

namespace FullStore.Domain.Entities
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Cpf { get; set; } 
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }

        public string NomeCompleto()
        {
            return $"{Nome} {Sobrenome}";
        }
    }
}
