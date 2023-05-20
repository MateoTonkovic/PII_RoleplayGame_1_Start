// Heroe
using System;
using System.Collections.Generic;

namespace Library
{
    public class Enano : Heroe
    {
        public Enano(string nombre) // constructor
        {
            this.Nombre = nombre;
            this.PuntosDeVictoria = 0;
        }
        public void RecibirCura(int cura) // método para ser curado por un elfo
        {
            this.Vida += cura;
        }
    }
}