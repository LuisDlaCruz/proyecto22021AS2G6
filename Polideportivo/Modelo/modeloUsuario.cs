﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class modeloUsuario
    {
        public int pkId { get; set; }
        public string nombre { get; set; }
        public string contraseña { get; set; }
        public int telefono { get; set; }
        public string tipo { get; set; }

        public modeloUsuario()
        {
        }

        public modeloUsuario(int Id, string Nombre, string Contraseña, int Telefono, string Tipo)
        {

            pkId = Id;
            nombre = Nombre;
            contraseña = Contraseña;
            telefono = Telefono;
            tipo = Tipo;



        }
    }
}