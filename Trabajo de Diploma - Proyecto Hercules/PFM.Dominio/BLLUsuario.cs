using AccesoDatos;
using Abstraccion;
using SERVICIOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using System.Dynamic;
using FRAMEWORK;
using System.Text.RegularExpressions;


namespace BLL
{
    public class BLLUsuario
    {
        DALUsuario _acceso = new DALUsuario();

        public bool ValidarUser(IUser usuario)
        {
            Regex RE = new Regex("^[a-zA-Z0-9]{4,15}$");
            bool esValido = RE.IsMatch(usuario.Username);

            return _acceso.ExisteUsuario(usuario) && esValido;
        }

        //valido si la password del usuario es valida
        public bool validarPass(IUser usuario)
        {
            return _acceso.validarPass(usuario);
        }

        //Metodo para validar contraseña REGEX
        public bool Validar_pass_regex(string pass)
        {
            ValidarRegex validador = new ValidarRegex();
            return validador.Validar_pass_regex(pass);
        }

        //Metodo para encriptar contraseña
        public string Encriptador(string pass)
        {
            Criptografia encriptador = new Criptografia();

            return encriptador.Encriptador(pass);
        }

        public void CerrarSesion()
        {

            Sesion.Logout();
        }

        public bool AltaUsuario(IUser user)
        {
            bool existoso = _acceso.AltaUsuario(user);
            if (existoso)
            {
                ActualizarDVV();
            }
            return existoso;
        }

        private void ActualizarDVV()
        {
            DalAccesoDatos accesoDatos = new DalAccesoDatos();
            string nuevoDVV = CalcularDVV();
            Console.WriteLine($"Nuevo DVV calculado: {nuevoDVV}"); 
            accesoDatos.ActualizarDVV(nuevoDVV);
        }

        public bool ModificarUsuario(BEUser usuarioLogueado)
        {
           return _acceso.ModificarUsuario(usuarioLogueado);

        }

        public BEUser ObtenerUsuarioLogueado()
        {
            Sesion sesion = Sesion.GetInstance;

            // Recupera el usuario de la sesión
            IUser user = sesion.User;
            return (BEUser)user;
        }

        public object ObtenerUsuarios()
        {
            DalAccesoDatos accesoDatos = new DalAccesoDatos();

            return accesoDatos.ObtenerUsuarios();
        }
        public BEUser ObtenerUsuario(string username)
        {
            DalAccesoDatos accesoDatos = new DalAccesoDatos();
            return accesoDatos.ObtenerUsuarioPorNombre(username); // Este método debe estar en tu capa de datos
        }

        //public List<BEPermiso> ObtenerPermisosUsuario(BEUser usuario)
        //{
        //    DalAccesoDatos accesoDatos = new DalAccesoDatos();

        //    return accesoDatos.ObtenerPermisosUsuario(usuario);

        //}

        public List<BEPermiso> ObtenerPermisosUsuario(BEUser usuario)
        {
            DALUsuario dalUsuario = new DALUsuario();
            DalAccesoDatos accesoDatos = new DalAccesoDatos();

            // Obtener permisos directos del usuario
            List<BEPermiso> permisosUsuario = accesoDatos.ObtenerPermisosUsuario(usuario);

            // Obtener permisos asociados al rol del usuario
            if (usuario.RolID.HasValue) // Ahora funcionará correctamente
            {
                List<BEPermiso> permisosRol = dalUsuario.ObtenerPermisosPorRol(usuario.RolID.Value);

                // Unir los permisos directos del usuario con los permisos del rol
                permisosUsuario.AddRange(permisosRol);
            }

            return permisosUsuario;
        }

        public string ObtenerDVH(BEUser user)
        {
            CreacionDV Gen = new CreacionDV();
            return Gen.Generar(user);
        }


        private bool SonValidosDVHs()
        {
            

            List<BEUser> Usuarios = (List<BEUser>)ObtenerUsuarios();
            foreach (BEUser Usuario in Usuarios)
            {
                string DVHCalculado = ObtenerDVH(Usuario);
                Console.WriteLine($"Usuario: {Usuario.Username}, DVH calculado: {DVHCalculado}, DVH almacenado: {Usuario.DVV}"); // Log para depuración
                if (!Usuario.DVV.Equals(DVHCalculado))
                {
                    Console.WriteLine($"DVH mismatch for user {Usuario.Username}. Calculated: {DVHCalculado}, Stored: {Usuario.DVV}"); // Para depuración
                    return false;
                }
            }
            return true;
        }


        public bool ModificarUsuario2(BEUser usuarioLogueado)
        {
            bool exitoso = _acceso.ModificarUsuario2(usuarioLogueado);

            if (exitoso)
            {
                ActualizarDVV();

            }

            return exitoso;
        }

        public List<BEUser> ObtenerVersiones(BEUser usuarioSeleccionado)
        {
            DalAccesoDatos accesoDatos = new DalAccesoDatos();

            return accesoDatos.ObtenerVersiones(usuarioSeleccionado);
        }

        public void ActualizarUsuario(BEUser usuarioSeleccionado)
        {
            Sesion.Instance().IniciarSesion(usuarioSeleccionado);
        }

        public bool EsValidoDVV()
        {
            if (!SonValidosDVHs())
            {
                Console.WriteLine("Los DVH no son válidos."); // Para depuración
                return false;
            }
            DALUsuario _accesos = new DALUsuario();
            string DVVCalculado = CalcularDVV();
            Console.WriteLine($"DVV calculado para validación: {DVVCalculado}"); // Para depuración

            return _accesos.ValidarDVV(DVVCalculado);
        }

        private string CalcularDVV()
        {
            List<BEUser> Usuarios = (List<BEUser>)ObtenerUsuarios();
            List<string> ListaDv = Usuarios.ConvertAll(user => user.DVV);
            CreacionDV GenDV = new CreacionDV();
            string dvv = GenDV.GenerarDVV(ListaDv);
            Console.WriteLine($"Lista de DVH para calcular DVV: {string.Join(",", ListaDv)}"); // Para depuración
            return dvv;
        }


    }
}
