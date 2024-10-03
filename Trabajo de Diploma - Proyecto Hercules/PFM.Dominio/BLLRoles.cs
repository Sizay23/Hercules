using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using BE;
using DAL;

namespace BL_L
{
    namespace BLL
    {
        public class BLLRoles
        {
            private DALUsuario accesoUsuario;

            public BLLRoles()
            {
                accesoUsuario = new DALUsuario(); // Inicialización del acceso a datos
            }

            public List<BERol> ObtenerTodosLosRoles()
            {
                return accesoUsuario.ObtenerRoles();
            }


        }
    }
}
