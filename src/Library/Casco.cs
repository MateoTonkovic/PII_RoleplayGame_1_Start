using System;
using System.Collections.Generic;

namespace Library
{
    public class Casco
    {
    	public int Ataque { get; set; }
    	public int Defensa { get; set; }

    	public Casco(int ataque, int defensa)
    	{
            this.Ataque = ataque;
            this.Defensa = defensa;
    	}


    }
}