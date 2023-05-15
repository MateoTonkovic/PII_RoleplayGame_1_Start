using System;
using System.Collections.Generic;

namespace Library
{
    public class Personaje
    {
        public string Nombre { get; set; }

        public int Vida { get; set; } = 100;

        public int Ataque { get; set; }

        public int Defensa { get; set; }

        public int Curacion { get; set; }

        public List<Elemento> Elementos = new List<Elemento>();
    }
}