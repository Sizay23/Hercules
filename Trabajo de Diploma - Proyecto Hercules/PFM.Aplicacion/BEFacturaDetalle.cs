using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEFacturaDetalle
    {
        public int FacturaDetalleID { get; set; }
        public int FacturaID { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }

        public decimal Subtotal => Cantidad * PrecioUnitario;

        public override string ToString()
        {
            return $"{Descripcion} x{Cantidad} - {Subtotal:C}";
        }
    }
}
