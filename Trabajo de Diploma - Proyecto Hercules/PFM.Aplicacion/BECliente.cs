using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BECliente
    {
        public int ClienteID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public DateTime FechaRegistro { get; set; }

        // Relación con las mascotas de este cliente
        public List<BEMascota> Mascotas { get; set; } = new List<BEMascota>();

        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }
    }
}
