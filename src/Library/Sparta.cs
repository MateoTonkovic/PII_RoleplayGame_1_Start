// Enemigo
using System;
using System.Collections.Generic;

namespace Library
{
    public class Sparta : Enemigo
    {

        public Sparta(string nombre, int puntoDeVictoria) 
        {
            this.Nombre = nombre;
            this.PuntosDeVictoria = puntoDeVictoria;
        }

    }
} 