using System;

namespace Expense.Models
{
    public abstract class Atividade
    {
        public Guid Id { get; set; }

        public string Descricao { get; set; } = null;

        public DateTime? DataInicio { get; set; }

        public DateTime? DataFim { get; set; }

        public bool Finalizada { get; set; } = false;

        public Guid? Id_Cliente { get; set; }

        public Guid? Id_Projeto { get; set; }

        public Guid? Id_Despesa { get; set; }

        public Guid? Id_Atividade_Tipo { get; set; }
    }

}
