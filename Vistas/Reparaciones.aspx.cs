using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaMantenimientoEquipos.Vistas
{
    public partial class ReparacionesPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarGrid();
            }
        }

        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Reparaciones"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }
                    }
                }
            }
        }

        private void MostrarAlerta(Control page, string mensaje)
        {
            string script = $"alert('{mensaje}');";
            ScriptManager.RegisterStartupScript(page, page.GetType(), "alert", script, true);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            string equipoID = row.Cells[1].Text;
            string fechaSolicitud = row.Cells[2].Text;
            string estado = row.Cells[3].Text;

            tEquipoID.Text = equipoID;
            tFechaSolicitud.Text = fechaSolicitud;
            tEstado.Text = estado;
        }

        protected void Borrar_Click(object sender, EventArgs e)
        {
            ClsReparaciones.ReparacionID = int.Parse(tReparacionID.Text);
            if (ClsReparaciones.BorrarReparacion() > 0)
            {
                MostrarAlerta(this, "Reparación Borrada");
                LlenarGrid();
            }
            else
            {
                MostrarAlerta(this, "Error al borrar la reparación");
            }
        }

        protected void Modificar_Click(object sender, EventArgs e)
        {
            ClsReparaciones.ReparacionID = int.Parse(tReparacionID.Text);
            ClsReparaciones.EquipoID = int.Parse(tEquipoID.Text);
            ClsReparaciones.FechaSolicitud = DateTime.Parse(tFechaSolicitud.Text);
            ClsReparaciones.Estado = tEstado.Text;

            if (ClsReparaciones.ModificarReparacion() > 0)
            {
                MostrarAlerta(this, "Reparación Modificada");
                LlenarGrid();
            }
            else
            {
                MostrarAlerta(this, "Error al modificar la reparación");
            }
        }

        protected void Agregar_Click(object sender, EventArgs e)
        {
            ClsReparaciones.EquipoID = int.Parse(tEquipoID.Text);
            ClsReparaciones.FechaSolicitud = DateTime.Parse(tFechaSolicitud.Text);
            ClsReparaciones.Estado = tEstado.Text;

            if (ClsReparaciones.AgregarReparacion() > 0)
            {
                MostrarAlerta(this, "Reparación Ingresada");
                LlenarGrid();
            }
            else
            {
                MostrarAlerta(this, "Error al ingresar la reparación");
            }
        }
    }

}