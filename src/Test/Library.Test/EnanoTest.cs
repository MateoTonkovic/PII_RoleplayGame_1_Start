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
            Enano enano = new Enano("Pedro");
            enano.AgregarElemento(new Lanza(10, 10));

            Assert.IsNotNull(enano);
        }

        [Test]
        public void EnanoDefensaTest()
        {

            Enano enano = new Enano("Pedro");
            enano.AgregarElemento(new Lanza(10, 10));


            Assert.AreEqual(10, enano.ObtenerDefensa());
        }

        [Test]
        public void EnanoVidaTest()
        {
            Enano enano = new Enano("Pedro");

            Assert.AreEqual(100, enano.Vida);
        }

        [Test]
        public void ElfoNombreTest()
        {
            Elfo elfo = new Elfo("Pedro");
            Assert.AreEqual("Pedro", elfo.Nombre);
        }
    }
}