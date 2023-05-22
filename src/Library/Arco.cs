using System;
using System.Collections.Generic;

namespace Library
{
    public class Arco : Elemento, IElemento
    {
        public Arco(int ataque, int defensa)
        {
            this.Ataque = ataque;
            this.Defensa = defensa;
        }


    }
}