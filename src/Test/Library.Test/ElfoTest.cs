using NUnit.Framework;

namespace Library.Test
{
    public class ElfoTest
    {
        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        public void ElfoConstructorTest()
        {
            Elfo elfo = new Elfo("Pedro");
            elfo.AgregarElemento(new Hacha(10, 10));

            Assert.IsNotNull(elfo);
        }

        [Test]
        public void ElfoDefensaTest()
        {

            Elfo elfo = new Elfo("Pedro");
            elfo.AgregarElemento(new Hacha(10, 10));


            Assert.AreEqual(10, elfo.ObtenerDefensa());
        }

        [Test]
        public void ElfoVidaTest()
        {
            Elfo elfo = new Elfo("Pedro");

            Assert.AreEqual(100, elfo.Vida);
        }

        [Test]
        public void ElfoNombreTest()
        {
            Elfo elfo = new Elfo("Pedro");
            Assert.AreEqual("Pedro", elfo.Nombre);
        }
    }
}