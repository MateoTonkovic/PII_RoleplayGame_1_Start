// Heroe
using System;
using System.Collections.Generic;

namespace Library
{
    public class Mago : Heroe
    {


        public Mago(string nombre)
        {
            this.Nombre = nombre;
            this.PuntosDeVictoria = 0;
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
