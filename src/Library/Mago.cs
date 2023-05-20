// Heroe
using System;
using System.Collections.Generic;

namespace Library
{
    public class Mago : Personaje
    {


        public Mago(string nombre)
        {
        }

        public void AgregarItemMagico(ILibroDeHechizo libroDeHechizo)
        {
            this.AgregarElemento(libroDeHechizo);
        }
    }
}
