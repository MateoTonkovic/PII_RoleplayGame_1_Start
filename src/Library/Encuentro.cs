using System;
using System.Collections.Generic;

namespace Library
{
    public class Encuentro
    {
        public List<IHeroe> Heroes = new List<IHeroe>();
        public List<IEnemigo> Enemigos = new List<IEnemigo>();

        public Encuentro(List<IHeroe> heroes, List<IEnemigo> enemigos)
        {
            this.Heroes = heroes;
            this.Enemigos = enemigos;
        }

        public void DoEncounter()
        {
            while (this.Heroes.Count > 0 && this.Enemigos.Count > 0)
            {

                if (this.Heroes.Count > 0)
                {

                    {
                        int positionToAttack = 0;

                        for (int i = 0; i < this.Heroes.Count; i++)
                        {
                            this.Lucha(this.Enemigos[i], this.Heroes[positionToAttack]);

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
                    {
                        int positionToAttack = 0;

                        for (int i = 0; i < this.Enemigos.Count; i++)
                        {
                            this.Lucha(this.Heroes[i], this.Enemigos[positionToAttack]);

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
                if (heroe.ObtenerVida() > 0 && heroe.ObtenerValorPuntosDeVictoria() >= 5)
                {
                    heroe.Vida = 100;
                }
            }
        }

        public void Lucha(IPersonaje atacante, IPersonaje defensor)
        {
            int power = atacante.ObtenerAtaque() - defensor.ObtenerDefensa();

            if (power > 0)
            {
                defensor.Vida -= power;
            }
        }

    }
}