using System;
using System.Collections.Generic;

namespace Library
{
    public class Heroe : Personaje, IHeroe
    {
        public int ValorPuntosDeVictoria { get; set; }

        public void AgregarPuntosDeVictoria(int puntosDeVictoria)
        {
            this.ValorPuntosDeVictoria += puntosDeVictoria;
        }
    }
}