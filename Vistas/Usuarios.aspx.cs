using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Runtime.Remoting.Channels;
using SistemaMantenimientoEquipos.CapaModelo;

namespace SistemaMantenimientoEquipos.Vistas
{
    public partial class Tecnico : System.Web.UI.Page
    {
        // Método que se ejecuta cuando la página carga
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // Solo cargar el grid en el primer acceso, no en postbacks
            {
                LlenarGrid();
            }
        }

        // Método para llenar el GridView con los datos de la base de datos
        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Tecnicos")) // Asegúrate de que el nombre de la tabla sea correcto
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

        // Método para mostrar una alerta
        private void MostrarAlerta(Control page, string mensaje)
        {
            string script = $"alert('{mensaje}');";
            ScriptManager.RegisterStartupScript(page, page.GetType(), "alert", script, true);
        }

        // Método que se ejecuta cuando se selecciona un técnico en el GridView
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener la fila seleccionada
            GridViewRow row = GridView1.SelectedRow;

            // Acceder a los valores de las celdas de la fila seleccionada
            string tecnicoNombre = row.Cells[1].Text;  // Nombre está en la segunda columna
            string tecnicoEspecialidad = row.Cells[2].Text;   // Especialidad está en la tercera columna

            // Mostrar los detalles en los TextBoxes
            tNombre.Text = tecnicoNombre;
            tEspecialidad.Text = tecnicoEspecialidad;
        }

        // Método para borrar un técnico
        protected void Borrar_Click(object sender, EventArgs e)
        {
            ClsTecnicos.Nombre = tNombre.Text;
            ClsTecnicos.Especialidad = tEspecialidad.Text;

            // Verificar si el técnico fue borrado correctamente
            if (ClsTecnicos.BorrarTecnico() > 0)
            {
                MostrarAlerta(this, "Técnico Borrado");
                LlenarGrid(); // Llenar el Grid después de la eliminación
            }
            else
            {
                MostrarAlerta(this, "Error al borrar el técnico");
            }
        }

        // Método para modificar un técnico
        protected void Modificar_Click(object sender, EventArgs e)
        {
            ClsTecnicos.Nombre = tNombre.Text;
            ClsTecnicos.Especialidad = tEspecialidad.Text;

            // Verificar si el técnico fue modificado correctamente
            if (ClsTecnicos.ModificarTecnico() > 0)
            {
                MostrarAlerta(this, "Técnico Modificado");
                LlenarGrid(); // Llenar el Grid después de la modificación
            }
            else
            {
                MostrarAlerta(this, "Error al modificar el técnico");
            }
        }

        // Método para agregar un técnico
        protected void Agregar_Click(object sender, EventArgs e)
        {
            ClsTecnicos.Nombre = tNombre.Text;
            ClsTecnicos.Especialidad = tEspecialidad.Text;

            // Verificar si el técnico fue agregado correctamente
            if (ClsTecnicos.AgregarTecnico() > 0)
            {
                MostrarAlerta(this, "Técnico Ingresado");
                LlenarGrid(); // Llenar el Grid después de la inserción
            }
            else
            {
                MostrarAlerta(this, "Error al ingresar el técnico");
            }
        }
    }
