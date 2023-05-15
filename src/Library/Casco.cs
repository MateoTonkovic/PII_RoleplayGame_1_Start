using System;
using System.Collections.Generic;

namespace Library
{
    public class Casco: Elemento, IElemento
    {
    	public Casco(int defensa)
    	{
            this.Defensa = defensa;
    	}
    }
}