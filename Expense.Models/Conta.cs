using System.Collections.Generic;

namespace Expense.Models
{
    public abstract class Conta
    {
        public string Descricao { get; set; }

        public string Documento { get; set; }

        public TipoDocumento TipoDocumento { get; set; }

        public ICollection<Endereco> Enderecos { get; set; }

        public ICollection<Contato> Contatos { get; set; }

        public ICollection<Projeto> Projetos { get; set; }

    }
}
