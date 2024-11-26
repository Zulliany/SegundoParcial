using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace SistemaMantenimientoEquipos.Capa_Logica
{
    public class Equipo
    {

        string connectionString = "Data Source=ZULIANYNARANJO\\SQLEXPRESS02;Initial Catalog=MantenimientoEquipos;Integrated Security=True";

        public static int IngresarEquipo(string TipoEquipo, string Modelo, string UsuarioID)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("IngresarEquipo", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@TipoEquipo", TipoEquipo));
                    cmd.Parameters.Add(new SqlParameter("@Especialidad", Modelo));
                    cmd.Parameters.Add(new SqlParameter("@UsuarioID", UsuarioID));


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
        public static int BorraEquipo(string TipoEquipo, string Modelo, string UsuarioID)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("BorrarEquipo", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add(new SqlParameter("@TipoEquipo", TipoEquipo));
                    cmd.Parameters.Add(new SqlParameter("@Especialidad", Modelo));
                    cmd.Parameters.Add(new SqlParameter("@UsuarioID", UsuarioID));


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
        public static int ModificarEquipo(string TipoEquipo, string Modelo, string UsuarioID)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("ModificarEquipo", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@TipoEquipo", TipoEquipo));
                    cmd.Parameters.Add(new SqlParameter("@Especialidad", Modelo));
                    cmd.Parameters.Add(new SqlParameter("@UsuarioID", UsuarioID));


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

