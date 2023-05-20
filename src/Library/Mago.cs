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
        public void AgregarHechizo(string hechizo)
        {
            
        }
        public void BorrarHechizo(string hechizo)
        {

        }
        public void AgregarElementoMagico(string item)
        {
            this.ElementosMagicos.Add(item);
        }
        public void BorrarElementoMagico(string item)
        {
            this.ElementosMagicos.Remove(item);
        }
    }
}
