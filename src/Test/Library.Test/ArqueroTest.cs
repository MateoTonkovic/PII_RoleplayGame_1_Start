namespace Library.Test
{
    public class ArqueroTest
    {
        [Test]
        public void ArqueroConstructorTest()
        {
            string nombre = "Pablo";
            int puntosDeVictoria = 5;

            Arquero arquero = new Arquero(nombre, puntosDeVictoria);

            Assert.AreEqual(nombre, arquero.Nombre);
            Assert.AreEqual(puntosDeVictoria,arquero.PuntosDeVictoria);
        }

        [Test]
        public void ArqueroAtaqueTest()
        {

            Arquero arquero = new Arquero("Pablo", 5);
            arquero.AgregarElemento(new Arco(25, 10));


            Assert.AreEqual(25, arquero.ObtenerAtaque());
        }

        [Test]
        public void ArqueroDefensaTest()
        {

            Arquero arquero = new Arquero("Pablo", 5);
            arquero.AgregarElemento(new Casco(20));


            Assert.AreEqual(20, arquero.ObtenerDefensa());
        }

        [Test]
        public void ArqueroVidaTest()
        {
            Arquero arquero = new Arquero("Pablo", 5);
            int vidaEsperada = 100;

            int vida = arquero.ObtenerVida();

            Assert.AreEqual(vidaEsperada, vida);

        }

        [Test]
        public void ArqueroCurarTest()
        {
            Arquero arquero = new Arquero("Pablo", 5);
            int vidaInicial = arquero.ObtenerVida();
            int puntosDeCuracion = 15;
            int vidaEsperada = vidaInicial + puntosDeCuracion;

            arquero.Curar(puntosDeCuracion);

            Assert.AreEqual(vidaEsperada, arquero.ObtenerVida());

        }

        [Test]
        public void ArqueroRecibirAtaqueTest()
        {
            Arquero arquero = new Arquero("Pablo", 5);
            int vidaInicial = arquero.ObtenerVida();
            int puntosDeDanio = 40;
            int vidaEsperada = vidaInicial - puntosDeDanio;

            arquero.RecibirAtaque(puntosDeDanio);

            Assert.AreEqual(vidaEsperada, arquero.ObtenerVida());
        }
    }
}