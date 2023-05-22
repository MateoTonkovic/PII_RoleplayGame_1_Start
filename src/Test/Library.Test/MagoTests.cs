namespace Library.Test
{
    public class MagoTest
    {
        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        public void MagoConstructorTest()
        {
            Mago mago = new Mago("Juan");
            mago.AgregarElementoMagico(new BastonMagico(10, 10));

            Assert.IsNotNull(mago);
        }

        [Test]
        public void MagoDefensaTest()
        {

            Mago mago = new Mago("Juan");
            IItemMagico bastonMagico = new BastonMagico(10, 10);
            mago.AgregarElementoMagico(bastonMagico);


            Assert.AreEqual(10, mago.ObtenerDefensa());
        }

        [Test]
        public void MagoVidaTest()
        {
            Mago mago = new Mago("Juan");

            Assert.AreEqual(100, mago.Vida);
        }

        [Test]
        public void MagoNombreTest()
        {
            Mago mago = new Mago("Juan");
            Assert.AreEqual("Juan", mago.Nombre);
        }
    }
}