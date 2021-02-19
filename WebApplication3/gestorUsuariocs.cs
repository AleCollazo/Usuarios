using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;

namespace WebApplication3
{
    public class Usuario
    {
        public string Nick { get; }
        public string Nombre { get; }
        public string Apellido { get; }
        public string Email { get; }
        public string Direccion { get; }
        public int Telefono { get; }

        public Usuario(string nick, string nombre, string apellido, string email, string direccion)
        {
            Nick = nick;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Direccion = direccion;
        }

        public override string ToString()
        {
            return string.Format("Usuario: {0}, Nombre: {1}, Apellido {2}, email {3}, Direccion {4}",
                Nick, Nombre, Apellido, Email, Direccion);
        }
    }

    public class gestorUsuariocs
    {
        

        
    }
}