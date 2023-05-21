using System;
using System.Collections.Generic;

namespace Library
{
    public class BastonMagico : IItemMagico
    {
        public int Ataque { get; set; }

        public int Defensa { get; set; }


        public BastonMagico(int ataque, int defensa)
        {
            this.Ataque = ataque;
            this.Defensa = defensa;
        }

        public int ObtenerValorAtaque()
        {
            return this.Ataque;
        }

        public int ObtenerValorDefensa()
        {
            return this.Defensa;
        }
    }
}