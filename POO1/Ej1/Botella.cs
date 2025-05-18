using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    internal class Botella
    {
        /// Constructor Botella
        public Botella(string color, string material)
        {
            this.color = color;
            this.material = material;
        }
        
        /// Sobrecargar el constructor
        public Botella() { }


        private int capacidad;
        private string color;
        private string material;

        public string Material {
            get { return this.material; } 
        }


        //Propiedad

        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }



    }
}
