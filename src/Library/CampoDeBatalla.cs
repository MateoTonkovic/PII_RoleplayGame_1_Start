using System;
using System.Collections.Generic;
using System.Threading;

namespace Library
{
    public class CampoDeBatalla
    {
        public List<IHeroe> Heroes = new List<IHeroe>();
        public List<IEnemigo> Enemigos = new List<IEnemigo>();

        public void AgregarHeroe(IHeroe heroe) { }

        public void AgregarEnemigo(IEnemigo enemigo) { }

        public void QuitarHeroe(IHeroe heroe) { }

        public void QuitarEnemigo(IEnemigo enemigo) { }

        public void DoEncounter() { }

        public void Lucha(IPersonaje atacante, IPersonaje defensor) { }
    }
}