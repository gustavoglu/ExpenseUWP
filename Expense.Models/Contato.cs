using System;

namespace Expense.Models
{
    public class Contato
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public string TelefoneAdicional { get; set; }

        public Guid Id_Conta { get; set; }

    }
}
