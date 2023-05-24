using System;
using System.Collections.Generic;
using System.Threading;

namespace Library
{
    public class Encuentro
    {
        public List<IHeroe> Heroes = new List<IHeroe>();
        public List<IEnemigo> Enemigos = new List<IEnemigo>();

        public void AgregarHeroe(IHeroe heroe)
        {
            this.Heroes.Add(heroe);
        }

        public void AgregarEnemigo(IEnemigo enemigo)
        {
            this.Enemigos.Add(enemigo);
        }

        public void QuitarHeroe(IHeroe heroe)
        {
            this.Heroes.Remove(heroe);
        }

        public void QuitarEnemigo(IEnemigo enemigo)
        {
            this.Enemigos.Remove(enemigo);
        }

        public void DoEncounter()
        {
            if (this.Heroes.Count == 0 || this.Enemigos.Count == 0)
            {
                throw new Exception("No hay heroes o enemigos");
            }

            while (this.Heroes.Count > 0 && this.Enemigos.Count > 0)
            {

                if (this.Heroes.Count > 0)
                {
                    Console.WriteLine("Los enemigos atacan");
                    delay();

                    {
                        int positionToAttack = 0;

                        for (int i = 0; i < this.Enemigos.Count; i++)
                        {
                            IHeroe heroe = this.Heroes[positionToAttack];
                            this.Lucha(this.Enemigos[i], heroe);

                            if (heroe.ObtenerVida() <= 0)
                            {
                                Console.WriteLine($"{heroe.Nombre} ha muerto");
                                this.Heroes.Remove(heroe);
                                delay();
                            }

                            if (i + 1 > Heroes.Count)
                            {
                                positionToAttack = 0;
                            }
                            else
                            {
                                positionToAttack = positionToAttack++;
                            }
                        }
                    }

                }

                if (this.Enemigos.Count > 0)
                {
                    Console.WriteLine("Los heroes atacan");
                    delay();

                    {
                        int positionToAttack = 0;

                        for (int i = 0; i < this.Heroes.Count; i++)
                        {
                            IEnemigo enemigo = this.Enemigos[positionToAttack];
                            IHeroe heroe = this.Heroes[i];

                            this.Lucha(heroe, enemigo);

                            if (enemigo.ObtenerVida() <= 0)
                            {
                                Console.WriteLine($"{enemigo.Nombre} ha muerto");
                                this.Enemigos.Remove(enemigo);
                                delay();

                                Console.WriteLine($"{heroe.Nombre} ha ganado {enemigo.ObtenerPuntosDeVictoria()} puntos de victoria");
                                heroe.AgregarPuntosDeVictoria(enemigo.ObtenerPuntosDeVictoria());
                                delay();
                            }

                            if (i + 1 > Enemigos.Count)
                            {
                                positionToAttack = 0;
                            }
                            else
                            {
                                positionToAttack = positionToAttack++;
                            }
                        }
                    }

                }

            }


            foreach (IHeroe heroe in this.Heroes)
            {
                if (heroe.ObtenerVida() > 0 && heroe.ObtenerPuntosDeVictoria() >= 5)
                {
                    Console.WriteLine($"{heroe.Nombre} tiene {heroe.ObtenerPuntosDeVictoria()} puntos de victoria y se regenera la vida");
                    delay();

                    heroe.Vida = 100;
                }
            }
        }

        public void Lucha(IPersonaje atacante, IPersonaje defensor)
        {
            Console.WriteLine($"{atacante.Nombre} ataca a {defensor.Nombre}");
            delay();

            int power = atacante.ObtenerAtaque() - defensor.ObtenerDefensa();

            if (power > 0)
            {
                Console.WriteLine($"{defensor.Nombre} recibe {power} de daño");
                delay();

                defensor.RecibirAtaque(power);
            }
        }

        public void delay()
        {
            Thread.Sleep(2000);
        }
    }
}
