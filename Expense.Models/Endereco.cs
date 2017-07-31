using System;

namespace Expense.Models
{
    public class Endereco
    {
        public string Rua { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string Pais { get; set; }

        public Guid  Id_Conta { get; set; }
    }
}
