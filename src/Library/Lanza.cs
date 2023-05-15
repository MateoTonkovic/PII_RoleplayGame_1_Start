using System;
using System.Collections.Generic;

namespace Library
{
    public class Lanza: Elemento, IElemento
    {
    	public Lanza(int ataque, int defensa)
    	{
            this.Ataque = ataque;
            this.Defensa = defensa;
    	}


    }
}