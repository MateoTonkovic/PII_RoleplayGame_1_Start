using System;
using System.Collections.Generic;
namespace Library
{

    public class Enemigo : Personaje, IPersonaje
    {
        public Enemigo(string nombre, int puntoDeVictoria)//CONSTRUCTOR 
        {
            this.Nombre = nombre;
            this.PuntosDeVictoria = puntoDeVictoria;
        }
    }
}