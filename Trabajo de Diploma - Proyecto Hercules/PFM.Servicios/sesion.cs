using Abstraccion;
using BE;
using FRAMEWORK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIOS
{
    public class Sesion
    {

        private static Sesion _sesion;
        public Traductor Traductor { get; set; }

        public IUser User { get; set; }
        private DateTime FechaInicioSesion { get; set; }

        private Sesion() {

            Traductor = new Traductor();
        }

        public static Sesion GetInstance
        {
            get
            {
                if (_sesion == null) throw new Exception("Sesión no iniciada");
                return _sesion;
            }
        }
        public static Sesion Instance()
        {
            if (_sesion == null)
            {
                _sesion = new Sesion();
                _sesion.Traductor = new Traductor();
            }
            return _sesion;
        }
        public static void Login(IUser user)
        {
            try
            {
                if (_sesion == null)
                {
                    _sesion = new Sesion();
                    _sesion.User = user;
                    _sesion.FechaInicioSesion = DateTime.Now;

                }
                else
                {
                    throw new Exception("Sesión iniciada");

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Logout()
        {
            try
            {
                _sesion = null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static string ObtenerUsername()
        {
            if (_sesion == null || _sesion.User == null)
            {
                throw new Exception("Sesión no iniciada o usuario no válido");
            }
            return _sesion.User.Username;
        }

        public void IniciarSesion(BEUser usuario)
        {
            User = usuario;
        }
    }

}