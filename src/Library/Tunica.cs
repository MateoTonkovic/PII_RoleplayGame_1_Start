using System;
using System.Collections.Generic;

namespace Library
{
    public class Tunica
    {
        public int Ataque { get; set; }
        public int Defensa { get; set; }

        public Tunica(int ataque, int defensa)
        {
            this.Ataque = ataque;
            this.Defensa = defensa;
        }

    }
}