using System;

namespace Expense.Models
{
    public class Projeto
    {
        public Guid? Id_Cliente { get; set; }

        public string Descricao { get; set; } = null;

        public double? CustoHoraPrev { get; set; }

        public int? HorasPrevistas { get; set; }

        public DateTime? DataInicio { get; set; }

        public DateTime? DataFim { get; set; }

        public double? CustoTotalHorasPrevistas { get; set; }

        public double? CustoTotalDespesasPrevistas { get; set; }

    }


}
