using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Regular : Alumno, IMantenimiento
    {
        private string semestre;
        private int creditosAcumulados;
        private int promedio;

        public string Semestre { get => semestre; set => semestre = value; }
        public int CreditosAcumulados { get => creditosAcumulados; set => creditosAcumulados = value; }
        public int Promedio { get => promedio; set => promedio = value; }

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