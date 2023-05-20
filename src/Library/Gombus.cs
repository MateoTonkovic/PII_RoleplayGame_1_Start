// Enemigo
using System;
using System.Collections.Generic;

namespace Library
{
    public class Gombus : Enemigo
    {

        public Gombus(string nombre, int puntoDeVictoria) 
        {
            this.Nombre = nombre;
            this.PuntosDeVictoria = puntoDeVictoria;
        }

    }
}