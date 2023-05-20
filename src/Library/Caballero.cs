// Enemigo
using System;
using System.Collections.Generic;

namespace Library
{
    public class Caballero : Enemigo
    {
        public Caballero(string nombre, int puntoDeVictoria)
        {
            this.Nombre = nombre;
            this.PuntosDeVictoria = puntoDeVictoria;
        }

    }
}