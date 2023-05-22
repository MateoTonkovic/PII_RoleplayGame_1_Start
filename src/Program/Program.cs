using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            CampoDeBatalla campoDeBatalla = new CampoDeBatalla();

            // Mago mago = new Mago("Gandalf");
            // LibroDeHechizo libroDeHechizo = new LibroDeHechizo();
            // Hechizo hechizo = new Hechizo("Hechizo 1", 30, 10);
            // libroDeHechizo.AgregarHechizo(hechizo);
            // mago.AgregarElementoMagico(libroDeHechizo);

            Elfo elfo = new Elfo("Heroe legolas", 10);
            Hacha hacha = new Hacha(90, 49);

            elfo.AgregarElemento(hacha);

            campoDeBatalla.AgregarHeroe(elfo);

            // campoDeBatalla.AgregarHeroe(mago);

            Arquero arquero = new Arquero("Legolas", 10);
            Caballero caballero = new Caballero("Aragorn", 10);

            // Escudo escudo = new Escudo();
            Lanza lanza = new Lanza(50, 1);

            // arquero.AgregarElemento(escudo);
            arquero.AgregarElemento(lanza);

            // caballero.AgregarElemento(escudo);
            caballero.AgregarElemento(lanza);
    
            campoDeBatalla.AgregarEnemigo(arquero);
            campoDeBatalla.AgregarEnemigo(caballero);

            campoDeBatalla.DoEncounter();
        }
    }
}
