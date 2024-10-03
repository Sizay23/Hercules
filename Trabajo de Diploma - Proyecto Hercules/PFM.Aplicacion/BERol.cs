using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BERol
    {
        public int RolID { get; set; }  // Identificador único del rol
        public string NombreRol { get; set; }  // Nombre del rol, como "Administrador", "Veterinario", "Recepcionista", etc.
        public string Descripcion { get; set; } // Descripción opcional del rol

        public override string ToString()
        {
            return NombreRol; // Para que se muestre correctamente en el ComboBox
        }
    }
}
