using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEHistorialMedico
    {
        public int HistorialMedicoID { get; set; }  // ID único del historial médico
        public int MascotaID { get; set; }  // ID de la mascota asociada
        public DateTime FechaVisita { get; set; }  // Fecha de la visita
        public string Diagnostico { get; set; }  // Diagnóstico realizado
        public string Tratamiento { get; set; }  // Tratamiento sugerido o realizado
        public string Observaciones { get; set; }  // Observaciones adicionales del veterinario
    }
}
