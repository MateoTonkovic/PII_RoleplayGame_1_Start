using System;
using System.Collections.Generic;

namespace Library
{
    public class Enano : Personaje, IPersonaje
    {

        public Enano(string nombre) // constructor
        {
            this.Nombre = nombre;
        }
    }
}