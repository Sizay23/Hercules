using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using DA_L;

namespace BL_L
{
    public class BLLTurno
    {
        private DALTurno _dalTurno;

        public BLLTurno()
        {
            _dalTurno = new DALTurno();
        }

        public List<BETurno> ObtenerTurnosPorMascota(int mascotaID)
        {
            return _dalTurno.ObtenerTurnosPorMascota(mascotaID);
        }

        public bool AgregarTurno(BETurno turno)
        {
            return _dalTurno.AgregarTurno(turno);
        }

        public bool ActualizarTurno(BETurno turno)
        {
            return _dalTurno.ActualizarTurno(turno);
        }

        public bool EliminarTurno(int turnoID)
        {
            return _dalTurno.EliminarTurno(turnoID);
        }
    }
}
