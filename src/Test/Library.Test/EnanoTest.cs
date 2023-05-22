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
        public void EnanoAtaqueTest()
        {
            Enano enano = new Enano("Carlos");
            enano.AgregarElemento(new Lanza(30,25));


            Assert.AreEqual(30, enano.ObtenerAtaque());

        }

        [Test]
        public void EnanoDefensaTest()
        {

            Enano enano = new Enano("Carlos");
            enano.AgregarElemento(new Lanza(30, 25));


            Assert.AreEqual(25, enano.ObtenerDefensa());
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
        public void EnanoAgregarElementoTest()
        {
            Enano enano = new Enano("Carlos");
            Hacha hacha = new Hacha(15, 10);

            enano.AgregarElemento(hacha);

            Assert.Contains(hacha, enano.Elementos);
        }

        [Test]
        public void EnanoQuitarElementoTest()
        {
            Enano enano = new Enano("Carlos");
            Hacha hacha = new Hacha(15, 10);
            enano.AgregarElemento(hacha);

            enano.QuitarElemento(hacha);

            Assert.IsFalse(enano.Elementos.Contains(hacha));
        }
    }
}