using Esparza.config;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Esparza
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            gdvAlumnos.DataSource = Index();
            gdvAlumnos.DataBind();
        }
        public DataTable Index()
        {
            Conexion.Conectar();
            DataTable data = new DataTable();
            string sql = "select * from alumno";
            SqlCommand cmd = new SqlCommand(sql, Conexion.Conectar());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(data);
            return data;
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRut.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtNota1.Text) ||
                string.IsNullOrWhiteSpace(txtNota2.Text) ||
                string.IsNullOrWhiteSpace(txtNota3.Text))
            {
                lblMensaje.Text = "Error: Todos los campos son obligatorios.";
                return;
            }

            double n1 = Convert.ToDouble(txtNota1.Text);
            double n2 = Convert.ToDouble(txtNota2.Text);
            double n3 = Convert.ToDouble(txtNota3.Text);
            double prom = Math.Round((n1 + n2 + n3) / 3, 1);

                if ((n1 < 1.0 || n1 > 7.0) || (n2 < 1.0 || n2 > 7.0) || (n3 < 1.0 || n3 > 7.0) || (prom < 1.0 || prom > 7.0))
            {
                lblMensaje.Text = "Error: Las notas deben ser entre 1,0 y 7,0";
                return;
            }

            Conexion.Conectar();
            string sql = "insert into alumno (rut, nombre, nota1, nota2, nota3, promfinal) values (@rut, @nombre, @n1, @n2, @n3, @prom)";
            SqlCommand cmd = new SqlCommand(sql, Conexion.Conectar());
            cmd.Parameters.AddWithValue("@rut", txtRut.Text);
            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@n1", n1);
            cmd.Parameters.AddWithValue("@n2", n2);
            cmd.Parameters.AddWithValue("@n3", n3);
            cmd.Parameters.AddWithValue("@prom", prom);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                lblMensaje.Text = "Alumno guardado";
                txtRut.Text = "";
                txtNombre.Text = "";
                txtNota1.Text = "";
                txtNota2.Text = "";
                txtNota3.Text = "";
                gdvAlumnos.DataSource = Index();
                gdvAlumnos.DataBind();
            }
            else
            {
                lblMensaje.Text = "Error al guardar";
            }
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        { 
            if (string.IsNullOrWhiteSpace(txtRut.Text))
            {
                lblMensaje.Text = "Debe ingresar el rut del alumno para eliminar";
                return;
            }

            Conexion.Conectar();
            string sql = "delete from Alumno where rut = @rut";
            SqlCommand cmd = new SqlCommand(sql, Conexion.Conectar());
            cmd.Parameters.AddWithValue("@rut", txtRut.Text);

            int i = cmd.ExecuteNonQuery();

            if (i != 0)
            {
                lblMensaje.Text = "Alumno elimnado";

                txtRut.Text = "";
                txtNombre.Text = "";
                txtNota1.Text = "";
                txtNota2.Text = "";
                txtNota3.Text = "";
                gdvAlumnos.DataSource = Index();
                gdvAlumnos.DataBind();
            }
            else
            {
                lblMensaje.Text = "No se encontró un alumno con ese rut";
            }
        }
    }
}
    