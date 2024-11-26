using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace SistemaMantenimientoEquipos.Capa_Logica
{
    public class asignaciones
    {
        string connectionString = "Data Source=ZULIANYNARANJO\\SQLEXPRESS02;Initial Catalog=MantenimientoEquipos;Integrated Security=True";

        public static int IngresarAsignaciones(string ReparacionID, string TecnicoID, string FechaAsignacion)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("IngresarAsignaciones", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ReparacionID", ReparacionID));
                    cmd.Parameters.Add(new SqlParameter("@Tecnico ID", TecnicoID);
                    cmd.Parameters.Add(new SqlParameter("@FechaAsignacion", FechaAsignacion);


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
        public static int BorraAsignaciones(string ReparacionID, string TecnicoID, string FechaAsignacion)

        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("BorrarAsignaciones", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add(new SqlParameter("@ReparacionID", ReparacionID));
                    cmd.Parameters.Add(new SqlParameter("@Tecnico ID", TecnicoID);
                    cmd.Parameters.Add(new SqlParameter("@FechaAsignacion", FechaAsignacion);


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
        public static int ModificarAsignaciones(string ReparacionID, string TecnicoID, string FechaAsignacion)

        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("ModificaAsignaciones", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ReparacionID", ReparacionID));
                    cmd.Parameters.Add(new SqlParameter("@Tecnico ID", TecnicoID);
                    cmd.Parameters.Add(new SqlParameter("@FechaAsignacion", FechaAsignacion);



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