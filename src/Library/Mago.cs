// Heroe
using System;
using System.Collections.Generic;

namespace Library
{
    public class Mago : Heroe, IPersonajeMagico
    {

        public List<ILibroDeHechizo> ElementosMagicos { get; set; } = new List<ILibroDeHechizo>();
        public Mago(string nombre)
        {
            this.Nombre = nombre;
            this.PuntosDeVictoria = 0;
        }

        public void AgregarElementoMagico(ILibroDeHechizo libroDeHechizo)
        {
            this.ElementosMagicos.Add(libroDeHechizo);
        }

        public void BorrarElementoMagico(ILibroDeHechizo libroDeHechizo)
        {
            this.ElementosMagicos.Remove(libroDeHechizo);
        }

        public void AgregarHechizo(Hechizo hechizo)
        {
            if (this.ElementosMagicos.Count > 0)
            {
                this.ElementosMagicos[0].AgregarHechizo(hechizo);
            }
            else
            {
                LibroDeHechizo libroDeHechizo = new LibroDeHechizo();
                libroDeHechizo.AgregarHechizo(hechizo);
            }
        }
        public void BorrarHechizo(Hechizo hechizo)
        {
            if (this.ElementosMagicos.Count > 0)
            {
                this.ElementosMagicos[0].QuitarHechizo(hechizo);
            }
        }

        public override int ObtenerAtaque()
        {
            int ataque = 0;

            foreach (ILibroDeHechizo elemento in this.ElementosMagicos)
            {
                foreach (Hechizo hechizo in elemento.Hechizos)
                {
                    ataque += hechizo.Ataque;
                }
            }

            ataque += base.ObtenerAtaque();

            return ataque;
        }

        public override int ObtenerDefensa()
        {
            int defensa = base.ObtenerDefensa(); ;

            foreach (ILibroDeHechizo elemento in this.ElementosMagicos)
            {
                foreach (Hechizo hechizo in elemento.Hechizos)
                {
                    defensa += hechizo.Defensa;
                }
            }

            return defensa;
        }
    }
}
