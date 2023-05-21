// Enemigo
using System;
using System.Collections.Generic;

namespace Library
{
    public class Orco : Enemigo
    {
        public Orco(string nombre, int puntosDeVictoria)
        {
            this.Nombre = nombre;
            this.PuntosDeVictoria = puntosDeVictoria;
        }

    }
}