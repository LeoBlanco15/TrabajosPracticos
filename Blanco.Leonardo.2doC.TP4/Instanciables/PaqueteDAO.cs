using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public static class PaqueteDAO
    {
        private static SqlCommand comando;
        private static SqlConnection conexion;

        /// <summary>
        /// inicializa todos los campos necesarios para guardar en base de datos
        /// </summary>
        static PaqueteDAO()
        {
            PaqueteDAO.conexion = new SqlConnection("Data Source = localhost; Database = correo-sp-2017; Trusted_Connection = True");
            PaqueteDAO.comando = new SqlCommand();
            PaqueteDAO.comando.Connection = PaqueteDAO.conexion;
        }
        /// <summary>
        /// sube a base de datos el paquete pasado como parametro
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool Insertar(Paquete p)
        {
            PaqueteDAO.comando.CommandText = "INSERT INTO Paquetes values (@DireccionEntrega, @TrackingId, @Alumno)";
            PaqueteDAO.comando.Parameters.Add(new SqlParameter("DireccionEntrega", p.DireccionEntrega));
            PaqueteDAO.comando.Parameters.Add(new SqlParameter("TrackingId", p.TrackingID));
            PaqueteDAO.comando.Parameters.Add(new SqlParameter("Alumno", "Leonardo Blanco"));

            PaqueteDAO.conexion.Open();

            PaqueteDAO.comando.ExecuteNonQuery();

            PaqueteDAO.conexion.Close();
            if (PaqueteDAO.conexion.State == System.Data.ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                throw new ArchivoExeption("La conexion no fue cerrada correctamente");
            }
        }

    }
}
