using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace SistemaMantenimientoEquipos.Capa_Logica
{
    public class Reparaciones
    {


        string connectionString = "Data Source=ZULIANYNARANJO\\SQLEXPRESS02;Initial Catalog=MantenimientoEquipos;Integrated Security=True";

        public static int IngresarReparacion(string EquipoID, string Fecha_Solicitud, string Estado)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("IngresarReparacion", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@EquipoID", EquipoID));
                    cmd.Parameters.Add(new SqlParameter("@Fecha_Solicitud", Fecha_Solicitud));
                    cmd.Parameters.Add(new SqlParameter("@Estado", Estado));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -0;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }
        public static int BorrarReparacion(string EquipoID, string Fecha_Solicitud, string Estado)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("BorrarReparacion", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@EquipoID", EquipoID));
                    cmd.Parameters.Add(new SqlParameter("@Fecha_Solicitud", Fecha_Solicitud));
                    cmd.Parameters.Add(new SqlParameter("@Estado", Estado));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -0;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }
        public static int ModificarReparacion(string EquipoID, string Fecha_Solicitud, string Estado)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("ModificarReparacion", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@EquipoID", EquipoID));
                    cmd.Parameters.Add(new SqlParameter("@Fecha_Solicitud", Fecha_Solicitud));
                    cmd.Parameters.Add(new SqlParameter("@Estado", Estado));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -0;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }

    }
}
