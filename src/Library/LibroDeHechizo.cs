using System;
using System.Collections.Generic;


namespace Library
{
    public class LibroDeHechizo: Elemento, IElemento
    {
        public void AgrgarHechizo(string nombreDeHechizo, int curacionDeHechizo, int ataqueDeHechizo, int defensaDeHechizo)
        {
            this.Hechizo.Add(nombreDeHechizo);
            this.Curacion += curacionDeHechizo;
            this.Ataque += ataqueDeHechizo;
            this.Defensa += defensaDeHechizo;
        }
    }
}
