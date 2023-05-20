using System;
using System.Collections.Generic;

namespace Library
{
    public class Heroe : Personaje, IHeroe
    {
        public void AgregarPuntosDeVictoria(int puntosDeVictoria)
        {
            this.PuntosDeVictoria += puntosDeVictoria;
        }
    }
}