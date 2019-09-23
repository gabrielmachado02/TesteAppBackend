using System;

namespace TesteApp.Model
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Cpf { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Email { get; set; }

        public string Logradouro { get; set; }

        public string Cep { get; set; }

        public string Cidade { get; set; }

        public int Numero { get; set; }
    }
}
