using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Alumno : Persona
    {
        private string seguro;
        private string escuela;

        public string Seguro { get => seguro; set => seguro = value; }
        public string Escuela { get => escuela; set => escuela = value; }

        public string Estudiar()
        {
            return "El metodo no ha sido implementado";
        }

    }
}