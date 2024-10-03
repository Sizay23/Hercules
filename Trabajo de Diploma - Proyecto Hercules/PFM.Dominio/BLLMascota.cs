using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;

namespace BL_L
{
    public class BLLMascota
    {
        private DALMascota _dalMascota;

        public BLLMascota()
        {
            _dalMascota = new DALMascota();
        }

        public List<BEMascota> ObtenerMascotasPorUsuario(string userName)
        {
            return _dalMascota.ObtenerMascotasPorUsuario(userName);
        }

        public bool AgregarMascota(BEMascota mascota)
        {
            // Validar los datos de la mascota antes de llamar a la capa DAL
            if (string.IsNullOrWhiteSpace(mascota.Nombre) || string.IsNullOrWhiteSpace(mascota.Especie))
            {
                throw new ArgumentException("El nombre y la especie son obligatorios.");
            }

            return _dalMascota.AgregarMascota(mascota);
        }

        public bool ActualizarMascota(BEMascota mascota)
        {
            return _dalMascota.ActualizarMascota(mascota);
        }

        public bool EliminarMascota(int mascotaID)
        {
            return _dalMascota.EliminarMascota(mascotaID);
        }
    }
}
