using System;
using System.Collections.Generic;
namespace Library
{

    public class Enanouno: Personaje, IPersonaje
    {
        public Enanouno(string nombre)//CONSTRUCTOR 
        {
            this.Nombre = nombre;
        }
        public void RecibirCura(int cura) // método para ser curado por un elfo
        {
            this.Vida += cura;
        }
    }
}