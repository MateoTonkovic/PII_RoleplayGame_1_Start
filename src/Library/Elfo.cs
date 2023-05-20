// Heroe
using System;
using System.Collections.Generic;

namespace Library
{
    public class Elfo : Heroe
    {
        public int Curacion { get; set; } = 10;
        public Elfo(string nombre, int curacion) 
        {
            this.Nombre = nombre;
            this.Curacion = curacion;
            this.PuntosDeVictoria = 0;
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