using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string nombre = tbxNombre.Text;
            string apellidos = tbxApellidos.Text;
            int edad = int.Parse(tbxEdad.Text);

            Persona p = new Persona(nombre, apellidos, edad);
            ListaPersonas.Personas.Add(p);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lbxPersonas.Items.Clear();
            foreach (Persona p in ListaPersonas.Personas)
            {
                lbxPersonas.Items.Add(p.ToString());
            }
            
        }
    }
}