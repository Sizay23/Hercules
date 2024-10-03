using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEMascota
    {
        public int MascotaID { get; set; }  // ID de la mascota
        public string Nombre { get; set; }  // Nombre de la mascota
        public string UserName { get; set; }  // Nombre del usuario dueño de la mascota
        public string Especie { get; set; }  // Especie de la mascota
        public string Raza { get; set; }  // Raza de la mascota
        public int Edad { get; set; }  // Edad de la mascota
        public char Sexo { get; set; }  // Sexo de la mascota
        public string Imagen { get; set; }  // Ruta de la imagen de la mascota
        public DateTime FechaRegistro { get; set; }  // Fecha en que se registró la mascota

        // Historial Médico asociado
        public List<BEHistorialMedico> HistorialMedico { get; set; }

        // Constructor
        public BEMascota()
        {
            HistorialMedico = new List<BEHistorialMedico>();
        }
    }
}
