﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio
{
    public class Persona
    {
        private string codigo;
        private string apellidos;
        private string nombres;
        private DateTime fechaNac;
        private string lugarNac;
        private string domicilio;
        private string correo;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public string LugarNac { get => lugarNac; set => lugarNac = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Correo { get => correo; set => correo = value; }

        public string Existir()
        {
            return "El metodod no ha sido implementado";
        }

        public string Asistir()
        {
            return "El metodod no ha sido implementado";
        }
    }
}