using System;
using System.Collections.Generic;

namespace Library
{
    public class Enemigo : IEnemigo
    {
        public string Nombre { get; set; }
        public int Vida { get; set; }
        public int Defensa { get; set; }
        public int Ataque { get; set; }
        public int ValorPuntosDeVictoria { get; set; }

        public Enemigo(string nombre, int vida)
        {
            this.Nombre = nombre;
            this.Vida = vida;
        }

    }
}