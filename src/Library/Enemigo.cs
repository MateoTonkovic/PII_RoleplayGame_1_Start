using System;
using System.Collections.Generic;
namespace Library
{

    public class Enemigo: Personaje, IPersonaje
    {
        public Enemigo(string nombre)//CONSTRUCTOR 
        {
            this.Nombre = nombre;
        }
    }
}