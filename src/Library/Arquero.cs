// Enemigo
using System;
using System.Collections.Generic;

namespace Library
{
    public class Arquero : Enemigo
    {

        public Arquero(string nombre, int puntoDeVictoria) 
        {
            this.Nombre = nombre;
            this.PuntosDeVictoria = puntoDeVictoria;
        }

    }
}