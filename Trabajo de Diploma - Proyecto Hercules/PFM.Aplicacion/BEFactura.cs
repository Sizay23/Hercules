using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEFactura
    {
        public int FacturaID { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; } // Ejemplo: Pendiente, Pagado

        // Relación con Cliente
        public int ClienteID { get; set; }
        public BECliente Cliente { get; set; }

        // Lista de detalles de la factura
        public List<BEFacturaDetalle> Detalles { get; set; } = new List<BEFacturaDetalle>();

        public override string ToString()
        {
            return $"Factura #{FacturaID} - {Cliente?.Nombre} {Cliente?.Apellido} - {Total:C}";
        }
    }
}
