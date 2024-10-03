using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BETurno
    {
        public int TurnoID { get; set; }  // ID único del turno
        public int MascotaID { get; set; }  // ID de la mascota asociada
        public DateTime FechaTurno { get; set; }  // Fecha del turno
        public string Observaciones { get; set; }  // Observaciones del turno
    }
}
