﻿using Dapper;
using Conexion;
using Modelo;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using Modelo.DTO;

namespace Controlador
{
    public class daoPuesto
    {
        private ConexionODBC ODBC = new ConexionODBC();

        public List<dtoPuesto> mostrarPuesto()
        {
            List<dtoPuesto> sqlresultado = new List<dtoPuesto>();
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM puestoempleado;";
                sqlresultado = conexionODBC.Query<dtoPuesto>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }

            return sqlresultado;
        }
    }
}