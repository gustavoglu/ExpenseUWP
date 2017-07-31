using System;

namespace Expense.Models
{
    public abstract class Despesa
    {
        public double Valor { get; set; }

        public Guid? Id_Despesa_Tipo { get; set; }

        public Guid? Id_Anexo { get; set; }
    }
}
