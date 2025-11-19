using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cobro
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal Importe { get; set; }
        public TipoCobro Tipo { get; set; }
        public bool Pagado { get; set; }
        public DateTime? FechaPago { get; set; }
        public decimal TotalPagado { get; set; } //Importe + recargo al momento del pago.
        public decimal CalcularRecargo(DateTime FechaPago)
        {
            if (FechaPago.Date <= FechaVencimiento.Date) return 0m;
            int diasAtraso = (FechaPago.Date - FechaVencimiento.Date).Days;
            if (Tipo == TipoCobro.Normal)
                return Importe * 0.01m * diasAtraso;
            else
                return 1000m * diasAtraso;
        }
        public decimal CalcularTotal(DateTime FechaPago)
            => Importe + CalcularRecargo(FechaPago);

        public enum TipoCobro
        {
            Normal,
            Especial
        }
    }

}
