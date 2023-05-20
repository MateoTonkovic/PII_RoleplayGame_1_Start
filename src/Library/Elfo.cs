// Heroe
using System;
using System.Collections.Generic;

namespace Library
{
    public class Elfo : Heroe
    {
        public Elfo(string nombre) // constructor
        {
            this.Nombre = nombre;
            this.PuntosDeVictoria = 0;
        }

        public int Curar(IPersonaje personaje)
        {
            return personaje.Vida += 10;
        }
    }
}