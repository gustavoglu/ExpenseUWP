using System;

namespace Expense.Models
{
    public class Atividade_Real : Atividade
    {
        public Guid? Id_Atividade_Prevista { get; set; }

        public StatusAcao StatusAcao  { get; set; }

        public bool SemTempo { get; set; } = true;
    }
}
