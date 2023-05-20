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
                    this.TurnoDeAtaque(this.Enemigos, this.Heroes);
                }

                if (this.Enemigos.Count > 0)
                {
                    this.TurnoDeAtaque(this.Heroes, this.Enemigos);
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

        public void TurnoDeAtaque(List<IPersonaje> atacantes, List<IPersonaje> defensores)
        {
            int positionToAttack = 0;

            for (int i = 0; i < defensores.Count; i++)
            {
                this.Lucha(atacantes[i], defensores[positionToAttack]);

                if (i + 1 > atacantes.Count)
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