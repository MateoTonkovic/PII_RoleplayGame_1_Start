using System;
using System.Collections.Generic;

namespace Library
{
    public class Heroe : Personaje, IHeroe
    {
        public int PuntosDeVictoria { get; set; } = 0;

        public void AgregarPuntosDeVictoria(int puntosDeVictoria)
        {
            this.PuntosDeVictoria += puntosDeVictoria;
        }
    }
}