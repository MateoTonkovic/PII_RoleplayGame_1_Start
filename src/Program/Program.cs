using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Encuentro encuentro = new Encuentro();


            Elfo elfo = new Elfo("Heroe legolas", 10);
            Hacha hacha = new Hacha(90, 49);

            elfo.AgregarElemento(hacha);

            encuentro.AgregarHeroe(elfo);

            Arquero arquero = new Arquero("Legolas", 10);
            Caballero caballero = new Caballero("Aragorn", 10);

            Lanza lanza = new Lanza(50, 1);

            arquero.AgregarElemento(lanza);

            caballero.AgregarElemento(lanza);

            encuentro.AgregarEnemigo(arquero);
            encuentro.AgregarEnemigo(caballero);

            encuentro.DoEncounter();
        }
    }
}
