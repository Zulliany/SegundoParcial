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
    public partial class DetallesReparacion : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                LlenarGrid();
                CargarDropdowns(); 
            }
        }

        /
        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM DetallesReparacion")) 
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

        /
        protected void CargarDropdowns()
        {
            // Cargar Reparaciones
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
        }

       
        private void MostrarAlerta(Control page, string mensaje)
        {
            string script = $"alert('{mensaje}');";
            ScriptManager.RegisterStartupScript(page, page.GetType(), "alert", script, true);
        }

        // Método que se ejecuta cuando se selecciona un detalle de reparación en el GridView
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            GridViewRow row = GridView1.SelectedRow;

            /
            string detalleID = row.Cells[1].Text;  
            string reparacionID = row.Cells[2].Text; 
            string descripcion = row.Cells[3].Text;   
            string fechaInicial = row.Cells[4].Text;  
            string fechaFinal = row.Cells[5].Text;   

            
            tDetalleID.Text = detalleID;
            ddlReparaciones.SelectedValue = reparacionID;
            tDescripcion.Text = descripcion;
            tFechaInicial.Text = fechaInicial;
            tFechaFinal.Text = fechaFinal;
        }

        
        protected void Borrar_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(tDetalleID.Text))
            {
                MostrarAlerta(this, "Debe seleccionar un detalle de reparación.");
                return;
            }

            ClsDetallesReparacion.DetalleID = int.Parse(tDetalleID.Text); 
                                                                          
            if (ClsDetallesReparacion.BorrarDetalle() > 0)
            {
                MostrarAlerta(this, "Detalle de reparación borrado");
                LlenarGrid(); 
            }
            else
            {
                MostrarAlerta(this, "Error al borrar el detalle de reparación");
            }
        }

       
        protected void Modificar_Click(object sender, EventArgs e)
        {
            
            if (ddlReparaciones.SelectedValue == "0")
            {
                MostrarAlerta(this, "Debe seleccionar una reparación.");
                return;
            }

            DateTime fechaInicial;
            DateTime fechaFinal;

            if (!DateTime.TryParse(tFechaInicial.Text, out fechaInicial))
            {
                MostrarAlerta(this, "La fecha inicial no es válida.");
                return;
            }

            if (!DateTime.TryParse(tFechaFinal.Text, out fechaFinal))
            {
                MostrarAlerta(this, "La fecha final no es válida.");
                return;
            }

            ClsDetallesReparacion.DetalleID = int.Parse(tDetalleID.Text);
            ClsDetallesReparacion.ReparacionID = int.Parse(ddlReparaciones.SelectedValue);
            ClsDetallesReparacion.Descripcion = tDescripcion.Text;
            ClsDetallesReparacion.FechaInicial = fechaInicial;
            ClsDetallesReparacion.FechaFinal = fechaFinal;


            if (ClsDetallesReparacion.ModificarDetalle() > 0)
            {
                MostrarAlerta(this, "Detalle de reparación modificado");
                LlenarGrid();
            }
            else
            {
                MostrarAlerta(this, "Error al modificar el detalle de reparación");
            }
        }

        
        protected void Agregar_Click(object sender, EventArgs e)
        {
            
            if (ddlReparaciones.SelectedValue == "0")
            {
                MostrarAlerta(this, "Debe seleccionar una reparación.");
                return;
            }

            DateTime fechaInicial;
            DateTime fechaFinal;

            if (!DateTime.TryParse(tFechaInicial.Text, out fechaInicial))
            {
                MostrarAlerta(this, "La fecha inicial no es válida.");
                return;
            }

            if (!DateTime.TryParse(tFechaFinal.Text, out fechaFinal))
            {
                MostrarAlerta(this, "La fecha final no es válida.");
                return;
            }

            ClsDetallesReparacion.ReparacionID = int.Parse(ddlReparaciones.SelectedValue);
            ClsDetallesReparacion.Descripcion = tDescripcion.Text;
            ClsDetallesReparacion.FechaInicial = fechaInicial;
            ClsDetallesReparacion.FechaFinal = fechaFinal;

            
            if (ClsDetallesReparacion.AgregarDetalle() > 0)
            {
                MostrarAlerta(this, "Detalle de reparación agregado");
                LlenarGrid(); 
            else
            {
                MostrarAlerta(this, "Error al agregar el detalle de reparación");
            }
        }
    }

}