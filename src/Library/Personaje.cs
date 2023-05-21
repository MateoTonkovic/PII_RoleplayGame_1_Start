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

        public List<IElemento> Elementos { get; set; } = new List<IElemento>();

        public int ObtenerVida()
        {
            return this.Vida;
        }

        public virtual int ObtenerAtaque()
        {
            int ataque = this.Ataque;

            foreach (Elemento elemento in this.Elementos)
            {
                ataque += elemento.Ataque;
            }

            return ataque;
        }

        public virtual int ObtenerDefensa()
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
            int daño = ataque - this.ObtenerDefensa();

            if (daño > 0)
            {
                if (this.Vida - daño < 0)
                {
                    this.Vida = 0;
                }
                else
                {
                    this.Vida -= daño;
                }
            }

        }

        public int ObtenerPuntosDeVictoria()
        {
            return this.PuntosDeVictoria;
        }
    }
}