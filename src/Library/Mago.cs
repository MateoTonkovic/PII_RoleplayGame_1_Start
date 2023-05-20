// Heroe
using System;
using System.Collections.Generic;

namespace Library
{
    public class Mago : Personaje, IPersonajeMagico
    {
        public List<ItemMagico> ElementosMagicos{ get ; set;}  = new List<ItemMagico>();      
        public Mago(string nombre)
        {
            this.Nombre = nombre;
        }
        public void AgregarHechizo(string hechizo)
        {
            
        }
        public void BorrarHechizo(string hechizo);
        public void AgregarElementoMagico(string item)
        {
            this.ElementosMagicos.Add(item);
        }
        public void BorrarElementoMagico(string item);
    }
}
