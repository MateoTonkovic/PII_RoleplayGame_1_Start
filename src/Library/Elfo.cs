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
        }
        
        public int Curar(IPersonaje personaje)
        {
            return personaje.Vida += 10;
        }
    }
}