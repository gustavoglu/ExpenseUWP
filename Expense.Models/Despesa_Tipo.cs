using System;
using System.Collections.Generic;
using System.Text;

namespace Expense.Models
{
    public class Despesa_Tipo
    {
        public string Descricao { get; set; }

        public ICollection<Despesa> Despesas  { get; set; }
    }
}
