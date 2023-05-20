// Enemigo
using System;
using System.Collections.Generic;

namespace Library
{
    public class Cronos : Enemigo
    {

        public Cronos(string nombre, int puntoDeVictoria) 
        {
            this.Nombre = nombre;
            this.PuntosDeVictoria = puntoDeVictoria;
        }

    }
}