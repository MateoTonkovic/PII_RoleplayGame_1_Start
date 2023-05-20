using System;
using System.Collections.Generic;

namespace Library
{
    public class Heroe : Personaje, IHeroe
    {
        public int ValorPuntosDeVictoria { get; set; }

        public Heroe(string nombre, int vida)
        {
            this.Nombre = nombre;
            this.Vida = vida;
        }

        public void AgregarPuntosDeVictoria(int puntosDeVictoria)
        {
            this.ValorPuntosDeVictoria += puntosDeVictoria;
        }
    }
}