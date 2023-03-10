using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea2
{
    public partial class _Default : Page
    {
        private void CargarDDL()
        {
            using (Entities db = new Entities())
            {
                var DatosEmpleados = (from c in db.Empleadoes
                             select new { c.Empleado_Id, FullName = c.Nombre +" "+ c.Apellido1+ " "+ c.Apellido2 }).ToList();
                
                var DatosEdificios = (from c in db.Edificios select c).ToList();

                var DatosProfesion = (from c in db.Profesions select c).ToList();

                DDLEmpleado.DataValueField = "Empleado_Id";
                DDLEmpleado.DataTextField = "FullName";
                DDLEmpleado.DataSource = DatosEmpleados;
                DDLEmpleado.DataBind();

                DDLEdificio.DataValueField = "Edificio_Id";
                DDLEdificio.DataTextField = "Nombre";
                DDLEdificio.DataSource = DatosEdificios;
                DDLEdificio.DataBind();


            }
        }

        private void AddCargo()
        {
            Ingreso ingreso = new Ingreso();
            ingreso.Empleado_Id = int.Parse(DDLEmpleado.SelectedValue);
            ingreso.Edificio_Id = int.Parse(DDLEdificio.SelectedValue);
            ingreso.Fecha = DateTime.Now;



            using (Entities db = new Entities())
            {
                db.Ingresoes.Add(ingreso);
                db.SaveChanges();

                DDLEmpleado.SelectedValue = null;
                DDLEdificio.SelectedValue = null;
            }
        }

        private void CargarGrid()
        {
            using (Entities db = new Entities())
            {
                var Datos = (from ingreso in db.Ingresoes
                             join empleado in db.Empleadoes
                             on ingreso.Empleado_Id equals empleado.Empleado_Id
                             join edificio in db.Edificios
                             on ingreso.Edificio_Id equals edificio.Edificio_Id
                             select new {
                                 Id = ingreso.Ingreso_Id,
                                 Nombre = empleado.Nombre+" "+empleado.Apellido1+ " "+ empleado.Apellido2,
                                 Edificio = edificio.Nombre,
                                 Fecha = ingreso.Fecha
                             }).ToList();

                GridView1.DataSource = Datos;
                GridView1.DataBind();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                CargarDDL();
                CargarGrid();
            }
            
        }



        protected void BTGuardar_Click(object sender, EventArgs e)
        {
            using (Entities db = new Entities())
            {
      

               
                    AddCargo();
                    CargarGrid();
                    LNota.Text = "";

            }

        }

        protected void DDLProfesion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}