// Heroe
using System;
using System.Collections.Generic;

namespace Library
{
    public class Mago : Heroe, IPersonajeMagico
    {

        public List<IItemMagico> ElementosMagicos { get; set; } = new List<IItemMagico>();
        public List<Hechizo> Hechizos { get; set; } = new List<Hechizo>();

        public Mago(string nombre)
        {
            this.Nombre = nombre;
            this.PuntosDeVictoria = 0;
        }

        public void AgregarElementoMagico(IItemMagico itemMagico)
        {
            this.ElementosMagicos.Add(itemMagico);
        }

        public void BorrarElementoMagico(IItemMagico itemMagico)
        {
            this.ElementosMagicos.Remove(itemMagico);
        }

        public void AgregarHechizo(Hechizo hechizo)
        {
            this.Hechizos.Add(hechizo);
        }

        public void BorrarHechizo(Hechizo hechizo)
        {
            this.Hechizos.Remove(hechizo);
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

            foreach (IItemMagico elemento in this.ElementosMagicos)
            {
                if (elemento is ILibroDeHechizo libroDeHechizo)
                {
                    foreach (Hechizo hechizo in libroDeHechizo.Hechizos)
                    {
                        defensa += hechizo.Defensa;
                    }
                }
                else if (elemento is BastonMagico bastonMagico)
                {
                    defensa += bastonMagico.Defensa;
                }
            }

            return defensa;
        }
    }
}
