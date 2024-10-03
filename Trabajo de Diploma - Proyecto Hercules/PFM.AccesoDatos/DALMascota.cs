using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace DAL
{
    public class DALMascota
    {
        private readonly string _connectionString;

        public DALMascota()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["tallerWest"].ConnectionString;
        }

        public List<BEMascota> ObtenerMascotasPorUsuario(string userName)
        {
            List<BEMascota> mascotas = new List<BEMascota>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("Sp_ObtenerMascotasPorUsuario", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserName", userName);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    BEMascota mascota = new BEMascota
                    {
                        MascotaID = Convert.ToInt32(reader["MascotaID"]),
                        Nombre = reader["Nombre"].ToString(),
                        UserName = reader["UserName"].ToString(),
                        Especie = reader["Especie"].ToString(),
                        Raza = reader["Raza"].ToString(),
                        Edad = Convert.ToInt32(reader["Edad"]),
                        Sexo = Convert.ToChar(reader["Sexo"]),
                        Imagen = reader["Imagen"].ToString(),
                        FechaRegistro = Convert.ToDateTime(reader["FechaRegistro"])
                    };
                    mascotas.Add(mascota);
                }
            }
            return mascotas;
        }

        public bool AgregarMascota(BEMascota mascota)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("Sp_AgregarMascota", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Nombre", mascota.Nombre);
                command.Parameters.AddWithValue("@UserName", mascota.UserName);
                command.Parameters.AddWithValue("@Especie", mascota.Especie);
                command.Parameters.AddWithValue("@Raza", mascota.Raza);
                command.Parameters.AddWithValue("@Edad", mascota.Edad);
                command.Parameters.AddWithValue("@Sexo", mascota.Sexo);
                command.Parameters.AddWithValue("@Imagen", mascota.Imagen);

                connection.Open();
                int result = command.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool ActualizarMascota(BEMascota mascota)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("Sp_ActualizarMascota", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MascotaID", mascota.MascotaID);
                command.Parameters.AddWithValue("@Nombre", mascota.Nombre);
                command.Parameters.AddWithValue("@Especie", mascota.Especie);
                command.Parameters.AddWithValue("@Raza", mascota.Raza);
                command.Parameters.AddWithValue("@Edad", mascota.Edad);
                command.Parameters.AddWithValue("@Sexo", mascota.Sexo);
                command.Parameters.AddWithValue("@Imagen", mascota.Imagen);

                connection.Open();
                int result = command.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool EliminarMascota(int mascotaID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("Sp_EliminarMascota", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MascotaID", mascotaID);

                connection.Open();
                int result = command.ExecuteNonQuery();
                return result > 0;
            }
        }
    }
}

