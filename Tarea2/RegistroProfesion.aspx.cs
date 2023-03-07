using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea2
{
    public partial class RegistroProfesion : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                CargarDDL();
            }
            CargarGrid();
        }

        private void CargarDDL()
        {
            using (Entities db = new Entities())
            {
                var Datos = (from c in db.TipoProfesionals
                             select new { c.TipoProfesional_Id, c.Nombre }).ToList();

                DDLTipo.DataValueField = "TipoProfesional_Id";
                DDLTipo.DataTextField = "Nombre";
                DDLTipo.DataSource = Datos;
                DDLTipo.DataBind(); 
            }
        }

        private void AddProfesion()
        {
            Profesion profesion = new Profesion();
            profesion.Nombre = TBNombre.Text;
            profesion.TipoProfesion_Id =int.Parse(DDLTipo.SelectedValue);

            using (Entities db = new Entities())
            {
                db.Profesions.Add(profesion);
                db.SaveChanges();

                TBNombre.Text = "";
                DDLTipo.SelectedValue = null;
            }
        }

        private void CargarGrid()
        {
            using (Entities db = new Entities())
            {
                var Datos = db.Profesions.Join(
                    db.TipoProfesionals,
                    p => p.TipoProfesion_Id,
                    e => e.TipoProfesional_Id,
                    (p,e) => new
                    {
                        Nombre = p.Nombre,
                        Tipo = e.Nombre,
                        Salario = e.Salario,
                    } 
                    ).ToList();

                GridView1.DataSource = Datos;
                GridView1.DataBind();
            }
        }

        protected void BTGuardar_Click(object sender, EventArgs e)
        {
            AddProfesion();
            CargarGrid();
        }
    }
}