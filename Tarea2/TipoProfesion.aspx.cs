using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tarea2
{
    public partial class TipoProfesion : Page
    {

        private List<TipoProfesional> selectTipoProfesion()
        {
            using(Entities db = new Entities())
            {
                return db.TipoProfesionals.ToList();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
             VerGrid();
            //GridView1.DataSource = selectTipoProfesion();
            //GridView1.DataBind();
            
        }
        private void AddTipo()
        {
            TipoProfesional tipoProfesional = new TipoProfesional();
            tipoProfesional.Nombre = TBNombre.Text;
            tipoProfesional.Salario = decimal.Parse(TBSalario.Text);
            using (Entities db = new Entities())
            {
                db.TipoProfesionals.Add(tipoProfesional);
                db.SaveChanges();

                TBNombre.Text = "";
                TBSalario.Text = "";
            }
        }

        private void VerGrid()
        {
            using(Entities db = new Entities())
            {
                /*IQueryable<TipoProfesional> oTipo = from q in db.TipoProfesionals 
                                                    select q;*/

                List<TipoProfesional> lista = db.TipoProfesionals.ToList();
                GridView1.DataSource = lista;
                GridView1.DataBind();
            }
        }

        protected void BTGuardar_Click(object sender, EventArgs e)
        {
            AddTipo();
            VerGrid();
        }
    }
}