using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BL_L
{
    public class BLLHistorialMedico
    {
        private DALHistorialMedico _dalHistorialMedico;

        public BLLHistorialMedico()
        {
            _dalHistorialMedico = new DALHistorialMedico();
        }

        public List<BEHistorialMedico> ObtenerHistorialMedicoPorMascota(int mascotaID)
        {
            return _dalHistorialMedico.ObtenerHistorialMedicoPorMascota(mascotaID);
        }

        public bool AgregarHistorialMedico(BEHistorialMedico historial)
        {
            return _dalHistorialMedico.AgregarHistorialMedico(historial);
        }

        public bool ActualizarHistorialMedico(BEHistorialMedico historial)
        {
            return _dalHistorialMedico.ActualizarHistorialMedico(historial);
        }
    }
}
