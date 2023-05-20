

using System;
using System.Collections.Generic;

namespace Library
{
    public class Encuentro
    {
        public List<IPersonaje> Heroes = new List<IPersonaje>();
        public List<IPersonaje> Enemigos = new List<IPersonaje>();

        public Encuentro(List<IPersonaje> heroes, List<IPersonaje> enemigos)
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
                    int positionToAttack = 0;

                    for (int i = 0; i < Enemigos.Count; i++)
                    {
                        this.Lucha(Heroes[i], Enemigos[positionToAttack]);


                        if (i-- > Heroes.Count)
                        {
                            positionToAttack = 0;
                        }
                        else
                        {
                            positionToAttack++;
                        }
                    }
                }

                // foreach (IPersonaje enemigo in this.Enemigos)
                // {
                //     if (this.Heroes.Count > 0)
                //     {
                //         this.Heroes[0].Vida -= enemigo.ObtenerAtaque() - this.Heroes[0].ObtenerDefensa();
                //         if (this.Heroes[0].Vida <= 0)
                //         {
                //             this.Heroes.RemoveAt(0);
                //         }
                //     }
                // }
                foreach (IPersonaje heroe in this.Heroes)
                {
                    foreach (IPersonaje enemigo in this.Enemigos)
                    {
                        enemigo.Vida -= heroe.ObtenerAtaque() - enemigo.ObtenerDefensa();
                        if (enemigo.Vida <= 0)
                        {
                            heroe.Vida += enemigo.ObtenerVida();
                            this.Enemigos.Remove(enemigo);
                            break;
                        }
                    }
                }
            }
            foreach (IPersonaje heroe in this.Heroes)
            {
                // if (heroe.ObtenerVida() > 0 && heroe.ObtenerPuntos() >= 5)
                // {
                //     heroe.Vida += 10;
                // }
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