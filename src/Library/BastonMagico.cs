using System;
using System.Collections.Generic;

namespace Library
{
    public class BastonMagico : Elemento, IElemento
    {
        public BastonMagico(int ataque, int defensa)
        {
            this.Ataque = ataque;
            this.Defensa = defensa;
        }
    }
}