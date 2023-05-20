// Heroe
using System;
using System.Collections.Generic;
namespace Library
{
    public class Elfouno : Heroe
    {
        public int Curacion { get; set; } = 10;

        public Elfouno(string nombre, int curacion)//CONSTRUCTOR 
        {
            this.Nombre = nombre;
            this.Curacion = curacion;
        }
        public int Curar(IPersonaje personaje)
        {
            int curacion = this.Curacion;

            foreach (Elemento elemento in this.Elementos)
            {
                curacion += elemento.Curacion;
            }

            return personaje.Vida += curacion;
        }
    }
}