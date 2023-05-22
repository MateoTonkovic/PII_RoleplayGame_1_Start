namespace Library.Test
{
    public class CaballeroTest
    {
        [Test]
        public void CaballeroConstructorTest()
        {
            string nombre = "Jorge";
            int puntosDeVictoria = 20;

            Caballero caballero = new Caballero(nombre, puntosDeVictoria);

            Assert.AreEqual(nombre, caballero.Nombre); // verifica que el nombre sea Jorge
            Assert.AreEqual(puntosDeVictoria,caballero.PuntosDeVictoria); // verifica que los puntos de victoria sea 20.
        }

        [Test]
        public void CaballeroAtaqueTest()
        {

            Caballero caballero = new Caballero("Jorge", 20);
            caballero.AgregarElemento(new Espada(20, 15));


            Assert.AreEqual(20, caballero.ObtenerAtaque());
        }

        [Test]
        public void CaballeroDefensaTest()
        {

            Caballero caballero = new Caballero("Jorge", 20);
            caballero.AgregarElemento(new Pechera(15));


            Assert.AreEqual(15, caballero.ObtenerDefensa());
        }

        [Test]
        public void CaballeroVidaTest()
        {
            Caballero caballero = new Caballero("Jorge", 20);
            int vidaEsperada = 100;

            int vida = caballero.ObtenerVida();

            Assert.AreEqual(vidaEsperada, vida);

        }

        [Test]
        public void CaballeroCurarTest()
        {
            Caballero caballero = new Caballero("Jorge", 20);
            int vidaInicial = caballero.ObtenerVida();
            int puntosDeCuracion = 25;
            int vidaEsperada = vidaInicial + puntosDeCuracion;

            caballero.Curar(puntosDeCuracion);

            Assert.AreEqual(vidaEsperada, caballero.ObtenerVida());

        }

        [Test]
        public void CaballeroRecibirAtaqueTest()
        {
            Caballero caballero = new Caballero("Jorge", 20);
            int vidaInicial = caballero.ObtenerVida();
            int puntosDeDanio = 30;
            int vidaEsperada = vidaInicial - puntosDeDanio;

            caballero.RecibirAtaque(puntosDeDanio);

            Assert.AreEqual(vidaEsperada, caballero.ObtenerVida());
        }
    }
}