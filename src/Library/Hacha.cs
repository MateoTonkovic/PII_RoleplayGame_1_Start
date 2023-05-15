using System;
using System.Collections.Generic;
namespace Library
{
    public class Hacha: Elemento, IElemento
    {
    	public Hacha(int ataque, int defensa)
    	{
            this.Ataque = ataque;
            this.Defensa = defensa;
    	}


    }
}