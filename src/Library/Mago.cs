using System;
using System.Collections.Generic;

namespace Library
{
    public class Mago : Personaje, IPersonaje
    {

        public Mago(string nombre)
        {
            this.Nombre = nombre;
        }
    }
}
