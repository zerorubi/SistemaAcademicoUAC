using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Profesor : Persona, IMantenimiento
    {
        private string especialidad;
        private string grado;
        private int añosServicio;

        public string Especialidad { get => especialidad; set => especialidad = value; }
        public string Grado { get => grado; set => grado = value; }
        public int AñosServicio { get => añosServicio; set => añosServicio = value; }

        public bool Actualizar()
        {
            throw new NotImplementedException();
        }

        public bool Agregar()
        {
            throw new NotImplementedException();
        }

        public string Buscar()
        {
            throw new NotImplementedException();
        }

        public bool Eliminar()
        {
            throw new NotImplementedException();
        }

        public string Listar()
        {
            throw new NotImplementedException();
        }
    }
}