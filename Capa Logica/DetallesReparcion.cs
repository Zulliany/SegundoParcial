using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace SistemaMantenimientoEquipos.Capa_Logica
{
    public class DetallesReparcion
    {
        public class asignaciones
        {
            string connectionString = "Data Source=ZULIANYNARANJO\\SQLEXPRESS02;Initial Catalog=MantenimientoEquipos;Integrated Security=True";

            public static int IngresarDetallesReparcion(string ReparacionID, string Descripcion, string FechaInicial, string FechaFinal)
            {
                int retorno = 0;
                SqlConnection Conn = new SqlConnection();
                try
                {
                    using (Conn = DBconn.obtenerConexion())
                    {
                        SqlCommand cmd = new SqlCommand("IngresarDetallesReparcion", Conn)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        cmd.Parameters.Add(new SqlParameter("@ReparacionID", ReparacionID));
                        cmd.Parameters.Add(new SqlParameter("@Descripcion", Descripcion);
                        cmd.Parameters.Add(new SqlParameter("@FechaIncial", FechaInicial);
                        cmd.Parameters.Add(new SqlParameter("@FechaFinall", FechaFinal);



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
            public static int BorraDetallesReparcion(string ReparacionID, string Descripcion, string FechaInicial, string FechaFinal)

            {
                int retorno = 0;
                SqlConnection Conn = new SqlConnection();
                try
                {
                    using (Conn = DBconn.obtenerConexion())
                    {
                        SqlCommand cmd = new SqlCommand("BorrarDetallesReparcion", Conn)
                        {
                            CommandType = CommandType.StoredProcedure
                        };

                        cmd.Parameters.Add(new SqlParameter("@ReparacionID", ReparacionID));
                        cmd.Parameters.Add(new SqlParameter("@Descripcion", Descripcion);
                        cmd.Parameters.Add(new SqlParameter("@FechaIncial", FechaInicial);
                        cmd.Parameters.Add(new SqlParameter("@FechaFinall", FechaFinal);


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
            public static int ModificarDetallesReparcion(string ReparacionID, string Descripcion, string FechaInicial, string FechaFinal)

            {
                int retorno = 0;
                SqlConnection Conn = new SqlConnection();
                try
                {
                    using (Conn = DBconn.obtenerConexion())
                    {
                        SqlCommand cmd = new SqlCommand("ModificacionDetallesReparcion", Conn)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        cmd.Parameters.Add(new SqlParameter("@ReparacionID", ReparacionID));
                        cmd.Parameters.Add(new SqlParameter("@Descripcion", Descripcion);
                        cmd.Parameters.Add(new SqlParameter("@FechaIncial", FechaInicial);
                        cmd.Parameters.Add(new SqlParameter("@FechaFinall", FechaFinal);



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
}