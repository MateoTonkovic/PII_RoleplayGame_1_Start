using System;
using System.Collections.Generic;

namespace Library
{
    public class Espada
    {
    	public int Ataque { get; set; }
    	public int Defensa { get; set; }

    	public Espada(int ataque, int defensa)
    	{
            this.Ataque = ataque;
            this.Defensa = defensa;
    	}


    }
}