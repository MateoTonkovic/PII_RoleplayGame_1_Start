using System;
using System.Collections.Generic;


namespace Library
{
    public class LibroDeHechizo
    {
        public int Ataque { get; set; } = 0;

        public int Defensa { get; set; } = 0;

        public int Curacion { get; set; } = 0;

        public List<string> Hechizo = new List<string>();


        public void AgrgarHechizo(string nombreDeHechizo, int curacionDeHechizo, int ataqueDeHechizo, int defensaDeHechizo)
        {
            this.Hechizo.Add(nombreDeHechizo);
            this.Curacion += curacionDeHechizo;
            this.Ataque += ataqueDeHechizo;
            this.Defensa += defensaDeHechizo;
        }
    }
}
