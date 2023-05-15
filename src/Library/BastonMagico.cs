using System;
using System.Collections.Generic;

namespace Library
{
    class BastonMagico
    {
        public int Ataque { get; }
        public int Defensa { get; }

        public BastonMagico(int ataque, int defensa)
        {
            this.Ataque = ataque;
            this.Defensa = defensa;
        }
    }
}

