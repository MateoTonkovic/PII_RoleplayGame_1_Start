using System;
using System.Collections.Generic;

namespace Library
{
    public class Personaje
    {
        public string Nombre { get; set; }

        public int Vida { get; set; } = 100;

        public int Ataque { get; set; }

        public int Defensa { get; set; }

        public int PuntosDeVictoria { get; set; }

        public List<IElemento> Elementos = new List<IElemento>();

        public int ObtenerVida()
        {
            return this.Vida;
        }

        public int ObtenerAtaque()
        {
            int ataque = this.Ataque;

            foreach (Elemento elemento in this.Elementos)
            {
                ataque += elemento.Ataque;
            }

            return ataque;
        }

        public int ObtenerDefensa()
        {
            int defensa = this.Defensa;

            foreach (Elemento elemento in this.Elementos)
            {
                defensa += elemento.Defensa;
            }

            return defensa;
        }

        public void AgregarElemento(IElemento elemento)
        {
            this.Elementos.Add(elemento);
        }

        public void QuitarElemento(IElemento elemento)
        {
            this.Elementos.Remove(elemento);
        }

        public void Curar(int vida)
        {
            this.Vida += vida;
        }

        public void RecibirAtaque(int ataque)
        {
            this.Vida -= ataque;
        }
    }
}