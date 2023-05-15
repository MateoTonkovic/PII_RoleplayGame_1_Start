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
        public void RecibirCura(int cura) // método para ser curado por un elfo
        {
            this.Vida += cura;
        }
    }
}