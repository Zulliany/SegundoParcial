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
    public partial class Equipos : System.Web.UI.Page
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
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Equipos"))
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
            string tipoEquipo = row.Cells[2].Text;
            string modelo = row.Cells[3].Text;
            string usuarioID = row.Cells[4].Text;

            tEquipoID.Text = equipoID;
            tTipoEquipo.Text = tipoEquipo;
            tModelo.Text = modelo;
            tUsuarioID.Text = usuarioID;
        }

        protected void Borrar_Click(object sender, EventArgs e)
        {
            ClsEquipos.EquipoID = int.Parse(tEquipoID.Text);
            if (ClsEquipos.BorrarEquipo() > 0)
            {
                MostrarAlerta(this, "Equipo Borrado");
                LlenarGrid();
            }
            else
            {
                MostrarAlerta(this, "Error al borrar el equipo");
            }
        }

        protected void Modificar_Click(object sender, EventArgs e)
        {
            ClsEquipos.EquipoID = int.Parse(tEquipoID.Text);
            ClsEquipos.TipoEquipo = tTipoEquipo.Text;
            ClsEquipos.Modelo = tModelo.Text;
            ClsEquipos.UsuarioID = int.Parse(tUsuarioID.Text);

            if (ClsEquipos.ModificarEquipo() > 0)
            {
                MostrarAlerta(this, "Equipo Modificado");
                LlenarGrid();
            }
            else
            {
                MostrarAlerta(this, "Error al modificar el equipo");
            }
        }

        protected void Agregar_Click(object sender, EventArgs e)
        {
            ClsEquipos.TipoEquipo = tTipoEquipo.Text;
            ClsEquipos.Modelo = tModelo.Text;
            ClsEquipos.UsuarioID = int.Parse(tUsuarioID.Text);

            if (ClsEquipos.AgregarEquipo() > 0)
            {
                MostrarAlerta(this, "Equipo Ingresado");
                LlenarGrid();
            }
            else
            {
                MostrarAlerta(this, "Error al ingresar el equipo");
            }
        }

        protected void Agregar_Click1(object sender, EventArgs e)
        {

        }
    }


}