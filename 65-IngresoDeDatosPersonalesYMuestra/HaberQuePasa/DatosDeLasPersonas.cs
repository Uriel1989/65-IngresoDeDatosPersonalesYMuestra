using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HaberQuePasa
{
    class DatosDeLasPersonas

    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int años { get; set; }
        public string nacionalidad { get; set; }

        public string personas ()
        {
            return "Los datos de estas personas son: " + this.nombre + ", apellido " + this.apellido + ", edad " + this.años + ", nacionalidad "+ this.nacionalidad;
        }
    }
}
