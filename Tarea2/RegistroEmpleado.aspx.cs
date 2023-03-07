using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea2
{
    public partial class RegistroEmpleado : Page
    {
        private void AddEmpleado()
        {
            Empleado empleado = new Empleado();
            empleado.Identificacion = int.Parse(TIdentificacion.Text);
            empleado.Nombre = TNombre.Text;
            empleado.Apellido1 = TApellido1.Text;
            empleado.Apellido2 = TApellido2.Text;
           empleado.FechaNacimiento = DateTime.Parse(txtEffDate.Text);


            using (Entities db = new Entities())
            {
                db.Empleadoes.Add(empleado);
                db.SaveChanges();

                TIdentificacion.Text = "";
                TNombre.Text = "";
                TApellido1.Text = "";
                TApellido2.Text = "";
                txtEffDate.Text = "";
            }
        }

        private void CargarGrid()
        {
            using (Entities db = new Entities())
            {
                var Datos = db.Empleadoes.ToList();

                GridView1.DataSource = Datos;
                GridView1.DataBind();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        protected void BTGuardar_Click(object sender, EventArgs e)
        {
            AddEmpleado();
            CargarGrid();
        }
    }
}