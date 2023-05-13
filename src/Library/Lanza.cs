using System;
using System.Collections.Generic;

namespace Library
{
    public class Lanza
    {
        public int Ataque { get; set; }
        public int Defensa { get; set; }

        public Lanza(int ataque, int defensa)
        {
            this.Ataque = ataque;
            this.Defensa = defensa;
        }

    }
}