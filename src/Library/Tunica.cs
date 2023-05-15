using System;
using System.Collections.Generic;

namespace Library
{
    public class Tunica: Elemento, IElemento
    {
    	public Tunica(int ataque, int defensa)
    	{
            this.Ataque = ataque;
            this.Defensa = defensa;
    	}

    }
}