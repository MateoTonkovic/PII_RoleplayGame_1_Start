using System;
using System.Collections.Generic;


namespace Library
{
    public class LibroDeHechizo : Elemento, IElemento
    {
        public List<Hechizo> Hechizos { get; set; } = new List<Hechizo>();

        public void AgrgarHechizo(Hechizo hechizo)
        {
            this.Hechizos.Add(hechizo);
            this.Ataque += hechizo.Ataque;
            this.Defensa += hechizo.Defensa;
        }

        public void QuitarHechizo(Hechizo hechizo)
        {
            this.Hechizos.Remove(hechizo);
            this.Ataque -= hechizo.Ataque;
            this.Defensa -= hechizo.Defensa;
        }
    }
}
