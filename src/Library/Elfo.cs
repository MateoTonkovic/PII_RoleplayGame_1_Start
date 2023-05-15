using System;
using System.Collections.Generic;

namespace Library
{
    public class Elfo : Personaje, IPersonaje
    {
        public int Curacion { get; set; } = 10;

        public Elfo(string nombre, int curacion) // constructor
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