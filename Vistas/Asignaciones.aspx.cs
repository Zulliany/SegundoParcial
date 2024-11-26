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
    public partial class Asignaciones : System.Web.UI.Page
    {
        // Método que se ejecuta cuando la página carga
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // Solo cargar el grid en el primer acceso, no en postbacks
            {
                LlenarGrid();
                CargarDropdowns(); // Cargar los Dropdowns para Reparaciones y Técnicos
            }
        }

        
        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Asignaciones")) 
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

      
        protected void CargarDropdowns()
        {
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT ReparacionID, Estado FROM Reparaciones", con))
                {
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    ddlReparaciones.DataSource = dr;
                    ddlReparaciones.DataTextField = "Estado";
                    ddlReparaciones.DataValueField = "ReparacionID";
                    ddlReparaciones.DataBind();
                    ddlReparaciones.Items.Insert(0, new ListItem("Seleccione Reparación", "0"));
                }
            }

            
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT TecnicoID, Nombre FROM Tecnicos", con))
                {
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    ddlTecnicos.DataSource = dr;
                    ddlTecnicos.DataTextField = "Nombre";
                    ddlTecnicos.DataValueField = "TecnicoID";
                    ddlTecnicos.DataBind();
                    ddlTecnicos.Items.Insert(0, new ListItem("Seleccione Técnico", "0"));
                }
            }
        }

        // Método para mostrar una alerta
        private void MostrarAlerta(Control page, string mensaje)
        {
            string script = $"alert('{mensaje}');";
            ScriptManager.RegisterStartupScript(page, page.GetType(), "alert", script, true);
        }

        // Método que se ejecuta cuando se selecciona una asignación en el GridView
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;

            
            string asignacionID = row.Cells[1].Text;  
            string reparacionID = row.Cells[2].Text;  
            string tecnicoID = row.Cells[3].Text;   
            string fechaAsignacion = row.Cells[4].Text;  

            
            tAsignacionID.Text = asignacionID;
            ddlReparaciones.SelectedValue = reparacionID;
            ddlTecnicos.SelectedValue = tecnicoID;
            tFechaAsignacion.Text = fechaAsignacion;
        }

        
        protected void Borrar_Click(object sender, EventArgs e)
        {
            ClsAsignaciones.AsignacionID = int.Parse(tAsignacionID.Text); 
            if (ClsAsignaciones.BorrarAsignacion() > 0)
            {
                MostrarAlerta(this, "Asignación Borrada");
                LlenarGrid(); 
            }
            else
            {
                MostrarAlerta(this, "Error al borrar la asignación");
            }
        }

        
        protected void Modificar_Click(object sender, EventArgs e)
        {
            ClsAsignaciones.AsignacionID = int.Parse(tAsignacionID.Text);
            ClsAsignaciones.ReparacionID = int.Parse(ddlReparaciones.SelectedValue);
            ClsAsignaciones.TecnicoID = int.Parse(ddlTecnicos.SelectedValue);
            ClsAsignaciones.FechaAsignacion = DateTime.Parse(tFechaAsignacion.Text);

            
            if (ClsAsignaciones.ModificarAsignacion() > 0)
            {
                MostrarAlerta(this, "Asignación Modificada");
                LlenarGrid(); 
            }
            else
            {
                MostrarAlerta(this, "Error al modificar la asignación");
            }
        }

        
        protected void Agregar_Click(object sender, EventArgs e)
        {
            ClsAsignaciones.ReparacionID = int.Parse(ddlReparaciones.SelectedValue);
            ClsAsignaciones.TecnicoID = int.Parse(ddlTecnicos.SelectedValue);
            ClsAsignaciones.FechaAsignacion = DateTime.Parse(tFechaAsignacion.Text);

           
            if (ClsAsignaciones.AgregarAsignacion() > 0)
            {
                MostrarAlerta(this, "Asignación Ingresada");
                LlenarGrid(); 
            }
            else
            {
                MostrarAlerta(this, "Error al ingresar la asignación");
            }
        }
    }

}