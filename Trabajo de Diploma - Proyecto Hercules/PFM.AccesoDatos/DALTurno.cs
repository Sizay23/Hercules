using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BE;
using System.Configuration;

namespace DA_L
{
    public class DALTurno
    {
        private readonly string _connectionString;

        public DALTurno()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["tallerWest"].ConnectionString;
        }

        public List<BETurno> ObtenerTurnosPorMascota(int mascotaID)
        {
            List<BETurno> turnos = new List<BETurno>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("Sp_ObtenerTurnosPorMascota", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MascotaID", mascotaID);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    BETurno turno = new BETurno
                    {
                        TurnoID = Convert.ToInt32(reader["TurnoID"]),
                        MascotaID = Convert.ToInt32(reader["MascotaID"]),
                        FechaTurno = Convert.ToDateTime(reader["FechaTurno"]),
                        Observaciones = reader["Observaciones"].ToString()
                    };
                    turnos.Add(turno);
                }
            }
            return turnos;
        }

        public bool AgregarTurno(BETurno turno)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("Sp_AgregarTurno", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MascotaID", turno.MascotaID);
                command.Parameters.AddWithValue("@FechaTurno", turno.FechaTurno);
                command.Parameters.AddWithValue("@Observaciones", turno.Observaciones);

                connection.Open();
                int result = command.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool ActualizarTurno(BETurno turno)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("Sp_ActualizarTurno", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@TurnoID", turno.TurnoID);
                command.Parameters.AddWithValue("@MascotaID", turno.MascotaID);
                command.Parameters.AddWithValue("@FechaTurno", turno.FechaTurno);
                command.Parameters.AddWithValue("@Observaciones", turno.Observaciones);

                connection.Open();
                int result = command.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool EliminarTurno(int turnoID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("Sp_EliminarTurno", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@TurnoID", turnoID);

                connection.Open();
                int result = command.ExecuteNonQuery();
                return result > 0;
            }
        }
    }
}
