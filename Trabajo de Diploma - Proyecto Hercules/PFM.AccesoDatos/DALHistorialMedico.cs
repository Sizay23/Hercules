using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BE;
using System.Configuration;
using System.Data;

namespace DAL
{
    public class DALHistorialMedico
    {
        private readonly string _connectionString;

        public DALHistorialMedico()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["tallerWest"].ConnectionString;
        }

        public List<BEHistorialMedico> ObtenerHistorialMedicoPorMascota(int mascotaID)
        {
            List<BEHistorialMedico> historialMedico = new List<BEHistorialMedico>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("Sp_ObtenerHistorialMedicoPorMascota", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MascotaID", mascotaID);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    BEHistorialMedico historial = new BEHistorialMedico
                    {
                        HistorialMedicoID = Convert.ToInt32(reader["HistorialMedicoID"]),
                        MascotaID = Convert.ToInt32(reader["MascotaID"]),
                        FechaVisita = Convert.ToDateTime(reader["FechaVisita"]),
                        Diagnostico = reader["Diagnostico"].ToString(),
                        Tratamiento = reader["Tratamiento"].ToString(),
                        Observaciones = reader["Observaciones"].ToString()
                    };
                    historialMedico.Add(historial);
                }
            }
            return historialMedico;
        }

        public bool AgregarHistorialMedico(BEHistorialMedico historial)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("Sp_AgregarHistorialMedico", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@MascotaID", historial.MascotaID);
                command.Parameters.AddWithValue("@FechaVisita", historial.FechaVisita);
                command.Parameters.AddWithValue("@Diagnostico", historial.Diagnostico);
                command.Parameters.AddWithValue("@Tratamiento", historial.Tratamiento);
                command.Parameters.AddWithValue("@Observaciones", historial.Observaciones);

                connection.Open();
                int result = command.ExecuteNonQuery();
                return result > 0;
            }
        }

        public bool ActualizarHistorialMedico(BEHistorialMedico historial)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("Sp_ActualizarHistorialMedico", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@HistorialMedicoID", historial.HistorialMedicoID);
                command.Parameters.AddWithValue("@MascotaID", historial.MascotaID);
                command.Parameters.AddWithValue("@FechaVisita", historial.FechaVisita);
                command.Parameters.AddWithValue("@Diagnostico", historial.Diagnostico);
                command.Parameters.AddWithValue("@Tratamiento", historial.Tratamiento);
                command.Parameters.AddWithValue("@Observaciones", historial.Observaciones);

                connection.Open();
                int result = command.ExecuteNonQuery();
                return result > 0;
            }
        }
    }
}
