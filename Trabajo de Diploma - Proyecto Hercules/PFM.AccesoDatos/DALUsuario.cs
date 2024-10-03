using Abstraccion;
using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Collections;
using DAL;

namespace AccesoDatos
{
    public class DALUsuario
    {
        public bool ExisteUsuario(IUser user)
        {
            bool UserOK = false;
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["tallerWest"].ConnectionString))
            {
                cnn.Open();
                using (SqlCommand command = new SqlCommand("SP_USER_VALIDAR_USUARIO", cnn))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Usuario", user.Username);
                        int count = (int)command.ExecuteScalar();
                        UserOK = count > 0;
                    }
            }
            return UserOK;
        }
       
        public bool validarPass(IUser user)
        {
            bool PasswordOK = false;
                using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["tallerWest"].ConnectionString))
                {
                    cnn.Open();
                    using (SqlCommand command = new SqlCommand("SP_USER_VALIDAR_PASS", cnn))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Usuario", user.Username);
                        command.Parameters.AddWithValue("@Password", user.Password);
                        int count = (int)command.ExecuteScalar();
                        PasswordOK = count > 0;
                    }
                }
                return PasswordOK;
        }

        public bool AltaUsuario(IUser user)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["tallerWest"].ConnectionString))
            {
                cnn.Open();
                SqlTransaction transaction = cnn.BeginTransaction();

                try
                {
                    using (SqlCommand command = new SqlCommand("SP_USER_ALTA", cnn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Transaction = transaction;
                        command.Parameters.AddWithValue("@Usuario", user.Username.Trim());
                        command.Parameters.AddWithValue("@Password", user.Password);
                        command.Parameters.AddWithValue("@DW", user.DVV);
                        command.Parameters.AddWithValue("@Nombre", user.Nombre.Trim());
                        command.Parameters.AddWithValue("@Apellido", user.Apellido.Trim());
                        command.Parameters.AddWithValue("@Mail", user.Mail.Trim());
                        command.Parameters.AddWithValue("@RolID", user.RolID);
                        command.ExecuteNonQuery();
                    }
                    transaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }


        public bool ModificarUsuario(IUser user)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["tallerWest"].ConnectionString))
            {
                cnn.Open();
                    using (SqlCommand command = new SqlCommand("SP_USER_MODIFICAR", cnn))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Usuario", user.Username);
                        command.Parameters.AddWithValue("@Password", user.Password);
                        command.ExecuteNonQuery();
                    }
                    return true;
            }
        }

        public bool ModificarUsuario2(BEUser usuarioLogueado)
        {
            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["tallerWest"].ConnectionString))
            {
                cnn.Open();
                using (SqlCommand command = new SqlCommand("SP_USER_MODIFICAR_Datos", cnn))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Usuario", usuarioLogueado.Username);
                    command.Parameters.AddWithValue("dvv", usuarioLogueado.DVV);
                    command.Parameters.AddWithValue("@Nombre", usuarioLogueado.Nombre);
                    command.Parameters.AddWithValue("@Apellido", usuarioLogueado.Apellido);
                    command.Parameters.AddWithValue("@Mail", usuarioLogueado.Mail);
                    command.Parameters.AddWithValue("@RolID", usuarioLogueado.RolID);
                    command.ExecuteNonQuery();
                }
                return true;
            }
        }

        public bool ValidarDVV(string dVVCalculado)
        {
            
            ArrayList ListaParametros = new ArrayList();
            //Defino lo que va a contener mi parametro 
            SqlParameter Parametro = new SqlParameter();
            Parametro.ParameterName = "@verificador";
            Parametro.Value = dVVCalculado;
            Parametro.SqlDbType = SqlDbType.VarChar;
            ListaParametros.Add(Parametro);

    
            DalAccesoDatos oAccesoDatosBase = new DalAccesoDatos();

            return oAccesoDatosBase.VerificarExistenciaBaseDatos("Sp_Verif_Verificar", ListaParametros);
        }


        public List<BERol> ObtenerRoles()
        {
            List<BERol> roles = new List<BERol>();

            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["tallerWest"].ConnectionString))
            {
                cnn.Open();
                using (SqlCommand command = new SqlCommand("SELECT RolID, NombreRol, Descripcion FROM Roles", cnn))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        BERol rol = new BERol
                        {
                            RolID = (int)reader["RolID"],
                            NombreRol = reader["NombreRol"].ToString(),
                            Descripcion = reader["Descripcion"].ToString()
                        };
                        roles.Add(rol);
                    }
                }
            }
            return roles;
        }

        public List<BEPermiso> ObtenerPermisosPorRol(int rolID)
        {
            List<BEPermiso> permisos = new List<BEPermiso>();

            using (SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["tallerWest"].ConnectionString))
            {
                cnn.Open();
                using (SqlCommand command = new SqlCommand("Sp_ObtenerPermisosPorRol", cnn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@RolID", rolID);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        BEPermiso permiso;

                        // Verifica el tipo de permiso y crea la instancia adecuada
                        bool esPadre = Convert.ToBoolean(reader["TipoPermiso"]);
                        if (esPadre)
                        {
                            permiso = new BEPadre();
                        }
                        else
                        {
                            permiso = new BEHijo();
                        }

                        permiso.Id = Convert.ToInt32(reader["IdPermiso"]);
                        permiso.NombrePermiso = reader["NombrePermiso"].ToString();

                        permisos.Add(permiso);
                    }
                }
            }
            return permisos;
        }

    }
}
