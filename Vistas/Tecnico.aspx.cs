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
    public partial class Tecnicos : System.Web.UI.Page
    {
        protected void bIngresar_Click(object sender, EventArgs e)
        {
            ClsTecnicos.Nombre = tNombre.Text;
            ClsTecnicos.Especialidad = tEspecialidad.Text;

            if (ClsTecnicos.AgregarTecnico() > 0)
            {
                MostrarAlerta(this, "Técnico Ingresado");
                LlenarGrid();
            }
            else
            {
                MostrarAlerta(this, "Error al ingresar el técnico");
            }
        }

        protected void bBorrar_Click(object sender, EventArgs e)
        {
            ClsTecnicos.Nombre = tNombre.Text;
            ClsTecnicos.Especialidad = tEspecialidad.Text;

            if (ClsTecnicos.BorrarTecnico() > 0)
            {
                MostrarAlerta(this, "Técnico Borrado");
                LlenarGrid();
            }
            else
            {
                MostrarAlerta(this, "Error al borrar el técnico");
            }
        }

        protected void bModificar_Click(object sender, EventArgs e)
        {
            ClsTecnicos.Nombre = tNombre.Text;
            ClsTecnicos.Especialidad = tEspecialidad.Text;

            if (ClsTecnicos.ModificarTecnico() > 0)
            {
                MostrarAlerta(this, "Técnico Modificado");
                LlenarGrid();
            }
            else
            {
                MostrarAlerta(this, "Error al modificar el técnico");
            }
        }

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
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Tecnicos"))
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
            string tecnicoNombre = row.Cells[1].Text;
            string tecnicoEspecialidad = row.Cells[2].Text;

            tNombre.Text = tecnicoNombre;
            tEspecialidad.Text = tecnicoEspecialidad;
        }
    }

}