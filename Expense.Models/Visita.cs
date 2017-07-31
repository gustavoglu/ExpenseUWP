using System;

namespace Expense.Models
{
    public class Visita
    {
        public Guid? Id_TipoVisita  { get; set; }

        public DateTime? Data { get; set; }

        public TimeSpan? HoraIni { get; set; }

        public TimeSpan? HoraFim { get; set; }

        public string Observacoes { get; set; } = null;

        public int? TempoImprodutivo { get; set; }

    }
}
