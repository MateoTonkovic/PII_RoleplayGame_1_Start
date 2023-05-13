using System;
using System.Collections.Generic;

namespace Library
{
    public class Elfo
    {
        public string Nombre { get; set; }
        public int Vida { get; set; }
        public List<string> Items { get; set; }

        public Elfo(string nombre, int vida) // constructor
        {
            this.Nombre = nombre;
            this.Vida = vida;
            this.Items = new List<string>();
        }

        public void Atacar() // método para atacar
        {
            Console.WriteLine($"{Nombre} ha atacado a un enemigo.");
        }

        /*
        public void Curar() // método para curar (creo que tendría que curar a otro, no a sí mismo)
        {
            Console.WriteLine($"{Nombre} se ha curado.");
        }
        */
        public int ObtenerAtaque() // método que retorna el valor del ataque
        {
            int ataque = 10;
            return ataque;
        }

        public int ObtenerDefensa() // método que retorna el valor de la defensa
        {
            int defensa = 10;
            return defensa;
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