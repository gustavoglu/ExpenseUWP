using System;
using System.Collections.Generic;

namespace Expense.Models
{
    public class Atividade_Prevista : Atividade
    {
        public int Ordem { get; set; }

        public StatusAtividadePrevista Status { get; set; }

        public DateTime? Prazo { get; set; }

        public TimeSpan? TempoResolucao { get; set; }

        public TimeSpan? TempoEstimado { get; set; }

        public TimeSpan? TempoApontado { get; set; }

        public Guid? Id_Atividade_Status { get; set; }

        public ICollection<Atividade_Real> Atividades  { get; set; }

    }
}
