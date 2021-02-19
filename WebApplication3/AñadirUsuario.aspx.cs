using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace WebApplication3
{
    public partial class AñadirUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnAñadir_Click(object sender, EventArgs e)
        {
            Insertarusuarios();
        }

        private void Insertarusuarios()
        {
            Usuario us = new Usuario(tbxNick.Text, tbxNombre.Text, tbxApellidos.Text, tbxEmail.Text, tbxDireccion.Text);
            string conStr = ConfigurationManager.ConnectionStrings["conUsers"].ConnectionString;
            SqlConnection con =  new SqlConnection(conStr);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO dbo.Usuarios (nick,Nombre,Apellido,Email,Direccion,telefono) VALUES(@param1,@param2,@param3,@param4,@param5,@param6)";

            cmd.Parameters.AddWithValue("@param1", us.Nick);
            cmd.Parameters.AddWithValue("@param2", us.Nombre);
            cmd.Parameters.AddWithValue("@param3", us.Apellido);
            cmd.Parameters.AddWithValue("@param4", us.Email);
            cmd.Parameters.AddWithValue("@param5", us.Direccion);
            cmd.Parameters.AddWithValue("@param6", int.Parse(tbxTelefono.Text));

            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}