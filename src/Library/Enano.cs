using System;
using System.Collections.Generic;

namespace Library
{
    public class Enano: Personaje, IPersonaje
    {

        public Enano(string nombre) // constructor
        {
            this.Nombre = nombre;
            this.Items = new List<string>();
        }

        public void Atacar() // método para atacar
        {
            Console.WriteLine($"{Nombre} ha atacado a un enemigo.");
        }

        public void AgregarItem(string item) // método para agregar items a la lista
        {
            Items.Add(item);
            Console.WriteLine($"{item} ha sido agregado al inventario de {Nombre}.");
        }

        public void RemoverItem(string item) // método para borrar items de la lista
        {
            if (Items.Contains(item))
            {
                Items.Remove(item);
                Console.WriteLine($"{item} ha sido removido del inventario de {Nombre}.");
            }
            else
            {
                Console.WriteLine($"{item} no se encontraba en el inventario de {Nombre}.");
            }
        }

        public void RecibirCura(int cura) // método para ser curado por un elfo
        {
            this.Vida += cura;
        }
    }
}