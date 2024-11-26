using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace SistemaMantenimientoEquipos.Capa_Logica
{
    public class Usuarios
    {
        string connectionString = "Data Source=ZULIANYNARANJO\\SQLEXPRESS02;Initial Catalog=Electronica;Integrated Security=True";

        public static int AgregarUsuario( string Nombre, string CorreoElectronico, string Telefono)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("IngresarUsuario", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@Nombre", Nombre));
                    cmd.Parameters.Add(new SqlParameter("@CorreoElectronico", CorreoElectronico));
                    cmd.Parameters.Add(new SqlParameter("@Telefono", Telefono));
                   
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
        public static int BorrarUsuario(string Nombre, string CorreoElectronico, string Telefono)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("BorrarUsuario", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@Nombre", Nombre));
                    cmd.Parameters.Add(new SqlParameter("@CorreoElectronico", CorreoElectronico));
                    cmd.Parameters.Add(new SqlParameter("@Telefono", Telefono));

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
        public static int ModificarUsuario(string Nombre, string CorreoElectronico, string Telefono)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("BorrUsuario", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@Nombre", Nombre));
                    cmd.Parameters.Add(new SqlParameter("@CorreoElectronico", CorreoElectronico));
                    cmd.Parameters.Add(new SqlParameter("@Telefono", Telefono));

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