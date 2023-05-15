using System;
using System.Collections.Generic;

namespace Library
{
    public class Escudo
    {
    	public int Ataque { get; set; }
    	public int Defensa { get; set; }

    	public Escudo(int ataque, int defensa)
    	{
            this.Ataque = ataque;
            this.Defensa = defensa;
    	}


    }
}