namespace Library.Test

{


    public class EncuentrosTest
    {
        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        public void AgregarHeroeTest()
        {

            Encuentro encuentro = new Encuentro();
            Elfo heroe = new Elfo("legolas", 10);
            // Act
            encuentro.AgregarHeroe(heroe);
            // Assert
            Assert.IsTrue(encuentro.Heroes.Contains(heroe));
        }

        [Test]
        public void AgregarEnemigoTest()
        {
            Encuentro encuentro = new Encuentro();
            Orco enemigo = new Orco("orco", 10);
            // Act
            encuentro.AgregarEnemigo(enemigo);
            // Assert
            Assert.IsTrue(encuentro.Enemigos.Contains(enemigo));
        }

        [Test]
        public void AtacarTest()
        {
            Encuentro encuentro = new Encuentro();
            Elfo heroe = new Elfo("legolas", 10);
            Orco enemigo = new Orco("orco", 4);

            Espada espada = new Espada(100, 10);
            Lanza lanza = new Lanza(30, 10);

            heroe.AgregarElemento(espada);
            enemigo.AgregarElemento(lanza);

            encuentro.AgregarHeroe(heroe);
            encuentro.AgregarEnemigo(enemigo);
            // Act

            encuentro.DoEncounter();
            // Assert
            Assert.AreEqual(0, enemigo.Vida);
            Assert.AreEqual(80, heroe.Vida);
        }


        [Test]
        public void AtacarTest2()
        {
            Encuentro encuentro = new Encuentro();
            Elfo elfoHeroe = new Elfo("legolas", 10);
            Enano enano = new Enano("enano");


            Orco enemigo = new Orco("orco", 4);

            Espada espada = new Espada(100, 10);
            Lanza lanza = new Lanza(30, 10);


            elfoHeroe.AgregarElemento(espada);
            enano.AgregarElemento(lanza);
            enemigo.AgregarElemento(lanza);

            encuentro.AgregarHeroe(elfoHeroe);
            encuentro.AgregarEnemigo(enemigo);


            encuentro.DoEncounter();
            // Assert
            Assert.AreEqual(0, enemigo.Vida);
            Assert.AreEqual(80, elfoHeroe.Vida);
            Assert.AreEqual(4, elfoHeroe.PuntosDeVictoria);
        }

        [Test]
        public void RecuperarVidaTest()
        {
            Encuentro encuentro = new Encuentro();
            Elfo elfoHeroe = new Elfo("legolas", 10);

            Orco enemigo = new Orco("orco", 10);

            Espada espada = new Espada(150, 10);
            Lanza lanza = new Lanza(30, 10);

            elfoHeroe.AgregarElemento(espada);
            enemigo.AgregarElemento(lanza);

            encuentro.AgregarHeroe(elfoHeroe);
            encuentro.AgregarEnemigo(enemigo);

            encuentro.DoEncounter();

            Assert.AreEqual(0, enemigo.Vida);
            Assert.AreEqual(100, elfoHeroe.Vida);
        }

        [Test]
        public void QuitarHeroeTest()
        {
            Encuentro encuentro = new Encuentro();
            Elfo elfoHeroe = new Elfo("legolas", 10);

            encuentro.AgregarHeroe(elfoHeroe);
            encuentro.QuitarHeroe(elfoHeroe);

            Assert.IsFalse(encuentro.Heroes.Contains(elfoHeroe));

        }

        [Test]
        public void QuitarEnemigoTest()
        {
            Encuentro encuentro = new Encuentro();
            Orco enemigo = new Orco("orco", 10);

            encuentro.AgregarEnemigo(enemigo);
            encuentro.QuitarEnemigo(enemigo);

            Assert.IsFalse(encuentro.Enemigos.Contains(enemigo));
        }
    }
}
