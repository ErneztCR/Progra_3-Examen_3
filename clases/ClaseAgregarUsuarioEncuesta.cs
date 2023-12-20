using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Examen_3_Ernesto_Vargas.clases
{
    public class ClaseAgregarUsuarioEncuesta
    {
        // Variables
        public static int EncuestaID { get; set; }
        public static string Nombre { get; set; }
        public static string FechaDeNacimiento { get; set; }
        public static string CorreoElectronico { get; set; }

        // Constructor
        public ClaseAgregarUsuarioEncuesta(int encuestaID, string nombre, string fechadenacimiento, string correoElectronico, string telefono)
        {
            EncuestaID = encuestaID;
            Nombre = nombre;
            FechaDeNacimiento = fechadenacimiento;
            CorreoElectronico = correoElectronico;
        }

        public ClaseAgregarUsuarioEncuesta() { }

        public static int Agregar(string nombre, string fechadenacimiento, string correo)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBConn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("AgregarUsuario", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@Nombre", nombre));
                    cmd.Parameters.Add(new SqlParameter("@FechaDeNacimiento", fechadenacimiento));
                    cmd.Parameters.Add(new SqlParameter("@CorreoElectronico", correo));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;

        }
    }
}
