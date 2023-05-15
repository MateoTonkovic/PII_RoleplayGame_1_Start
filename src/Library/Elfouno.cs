using System;
using System.Collections.Generic;
namespace Library
{

    public class Elfouno : Personaje, IPersonaje
    {
        public List<string> Items { get; set; }
        public Elfouno(string nombre)//CONSTRUCTOR 
        {
            this.Nombre = nombre;
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
    }
}