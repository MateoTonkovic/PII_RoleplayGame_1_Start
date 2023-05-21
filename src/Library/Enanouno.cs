// Heroe
using System;
using System.Collections.Generic;

namespace Library
{

    public class Enanouno : Heroe
    {
        public Enanouno(string nombre)//CONSTRUCTOR 
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