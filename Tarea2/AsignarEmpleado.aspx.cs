using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea2
{
    public partial class AsignarEmpleado : Page
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

                DDLProfesion.DataValueField = "Profesion_Id";
                DDLProfesion.DataTextField = "Nombre";
                DDLProfesion.DataSource = DatosProfesion;
                DDLProfesion.DataBind();


            }
        }

        private void AddCargo()
        {
            EmpleadoEdificioProfesion cargo = new EmpleadoEdificioProfesion();
            cargo.Empleado_Id = int.Parse(DDLEmpleado.SelectedValue);
            cargo.Edificio_Id = int.Parse(DDLEdificio.SelectedValue);
            cargo.Profesion_Id = int.Parse(DDLProfesion.SelectedValue);
            cargo.IsAcenso = CBAscenso.Checked;
            cargo.Fecha = DateTime.Now;


            using (Entities db = new Entities())
            {
                db.EmpleadoEdificioProfesions.Add(cargo);
                db.SaveChanges();

                DDLEmpleado.SelectedValue = null;
                DDLEdificio.SelectedValue = null;
                DDLProfesion.SelectedValue = null;
                CBAscenso.Checked = false;  
            }
        }

        private void CargarGrid()
        {
            using (Entities db = new Entities())
            {
                var Datos = (from cargo in db.EmpleadoEdificioProfesions
                             join empleado in db.Empleadoes
                             on cargo.Empleado_Id equals empleado.Empleado_Id
                             join edificio in db.Edificios
                             on cargo.Edificio_Id equals edificio.Edificio_Id
                             join profesion in db.Profesions
                             on cargo.Profesion_Id equals profesion.Profesion_Id
                             select new {
                                 Id = cargo.Cargo_Id,
                                 Nombre = empleado.Nombre+" "+empleado.Apellido1+ " "+ empleado.Apellido2,
                                 Edificio = edificio.Nombre,
                                 Profesion = profesion.Nombre,
                                 Ascenco = cargo.IsAcenso,
                                 Fecha = cargo.Fecha
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
                int Empleado = int.Parse(DDLEmpleado.SelectedValue);
                var Datos = db.EmpleadoEdificioProfesions.Where(o => o.Empleado_Id == Empleado).ToList();

                if(Datos.Count == 0 || CBAscenso.Checked)
                {
                    AddCargo();
                    CargarGrid();
                    LNota.Text = "";
                }
                else
                {
                    LNota.Text = "Ups!! Ya existe este empleado con un trabajo asignado";
                    LNota.ForeColor = Color.Red;
                    LNota.Font.Bold = true;
                }

            }

        }

        protected void DDLProfesion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}