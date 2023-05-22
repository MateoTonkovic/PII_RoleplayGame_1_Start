namespace Library.Test
{
    public class LibroDeHechizoTest
    {
        public LibroDeHechizo libroDeHechizo;

        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        public void LibroDeHechizoConstructorTest()
        {
            libroDeHechizo = new LibroDeHechizo();

            Assert.IsNotNull(libroDeHechizo);
        }

        [Test]
        public void LibroDeHechizoAtaqueTest()
        {
            libroDeHechizo = new LibroDeHechizo();

            Assert.AreEqual(0, libroDeHechizo.Ataque);
        }

        [Test]
        public void LibroDeHechizoDefensaTest()
        {
            libroDeHechizo = new LibroDeHechizo();

            Assert.AreEqual(0, libroDeHechizo.Defensa);
        }

        [Test]
        public void LibroDeHechizoCuracionTest()
        {
            libroDeHechizo = new LibroDeHechizo();

            Assert.AreEqual(0, libroDeHechizo.Curacion);
        }

        [Test]
        public void LibroDeHechizoAgregarHechizoTest()
        {
            LibroDeHechizo libroDeHechizo = new LibroDeHechizo();
            Hechizo hechizo = new Hechizo("Hechizo1", 10, 10);

            libroDeHechizo.AgregarHechizo(hechizo);

            Assert.AreEqual(10, libroDeHechizo.Ataque);
            Assert.AreEqual(10, libroDeHechizo.Defensa);
        }

        [Test]
        public void LibroDeHechizoAgregarHechizoTest2()
        {
            LibroDeHechizo libroDeHechizo = new LibroDeHechizo();
            Hechizo hechizo = new Hechizo("Hechizo1", 10, 10);
            Hechizo hechizo2 = new Hechizo("Hechizo2", 10, 10);

            libroDeHechizo.AgregarHechizo(hechizo);
            libroDeHechizo.AgregarHechizo(hechizo2);

            Assert.AreEqual(20, libroDeHechizo.Ataque);
            Assert.AreEqual(20, libroDeHechizo.Defensa);
        }
    }
}