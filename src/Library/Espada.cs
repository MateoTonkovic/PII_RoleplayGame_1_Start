using System;
using System.Collections.Generic;

namespace Library
{
    public class Espada: Elemento, IElemento
    {
    	public Espada(int ataque, int defensa)
    	{
            this.Ataque = ataque;
            this.Defensa = defensa;
    	}

    }
}