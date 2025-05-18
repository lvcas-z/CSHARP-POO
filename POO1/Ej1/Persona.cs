using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    internal class Persona
    {
        // Persona: Edad , Sueldo , Nombre = ATRIBUTOS O DATOS MIEMBROS

        private int edad;
        private float sueldo;
        private string nombre;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        //Getters - Setters
        public void setEdad (int e)
        {
            edad = e;
        }

        public int getEdad() { 
            return edad;    
        }

        // Metodos

        public string saludar()
        {
            return "Hola soy..." + nombre;
        }


    }
}
