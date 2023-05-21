using NUnit.Framework;

namespace Library.Test
{
    public class EnanoTest
    {
        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        public void EnanoConstructorTest()
        {
            Enano enano = new Enano("Carlos");

            Assert.IsNotNull(enano);
        }

        [Test]
        public void EnanoCurarTest()
        {
            Enano enano = new Enano("Carlos");
            int vidaInicial = enano.ObtenerVida();
            int puntosDeCuracion = 10;
            int vidaEsperada = vidaInicial + puntosDeCuracion;

            enano.Curar(puntosDeCuracion);

            Assert.AreEqual(vidaEsperada, enano.ObtenerVida());

        }

        [Test]
        public void EnanoDefensaTest()
        {

            Enano enano = new Enano("Carlos");
            enano.AgregarElemento(new Lanza(10, 10));


            Assert.AreEqual(10, enano.ObtenerDefensa());
        }

        [Test]
        public void EnanoVidaTest()
        {
            Enano enano = new Enano("Carlos");

            Assert.AreEqual(100, enano.Vida);
        }

        [Test]
        public void EnanoNombreTest()
        {
            Enano enano = new Enano("Carlos");
            Assert.AreEqual("Carlos", enano.Nombre);
        }

        [Test]
        public void EnanoAtaqueTest()
        {
            Enano enano = new Enano("Carlos");
            int ataqueEsperado = 30;

            int ataque = enano.ObtenerAtaque();

            Assert.AreEqual(ataqueEsperado, ataque);

        }
    }
}