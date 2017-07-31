using System;

namespace Expense.Models
{
    public class Atividade_Status
    {
        public Guid Id { get; set; }

        public string Descricao { get; set; } = null;

        public StatusAcao AtividadeRealizadaAcao { get; set; }

        public StatusAcao AtividadePrevistaAcao  { get; set; }
    }
}
