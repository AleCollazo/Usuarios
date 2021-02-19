using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3
{
    public class Persona
    {
        public string Nombre { get; }
        public string Apellidos { get; }
        public int Edad { get; }

        public Persona(string nombre, string apellidos, int edad)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, {2} años",
                Nombre, Apellidos, Edad);
        }
    }

    public static class ListaPersonas
    {
        public static List<Persona> Personas = new List<Persona>();
    }
}