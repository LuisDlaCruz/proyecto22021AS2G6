﻿namespace Modelo.DTO
{
    public class dtoDeporte
    {
        public int pkId { get; set; }
        public string nombre { get; set; }

        public dtoDeporte()
        {
        }

        public dtoDeporte(int Id, string Nombre)
        {
            pkId = Id;
            nombre = Nombre;
            //para cuando sean ints
            //int numeroValor = 0;
            //int.TryParse(numero, out numeroValor);
            //Numero = numeroValor;
        }
    }
}