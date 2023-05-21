namespace Library.Test
{
    public class ElfoTest
    {
        [Test]
        public void ElfoConstructorTest()
        {
            Elfo elfo = new Elfo("Pedro", 10);

            Assert.IsNotNull(elfo);
        }

        [Test]
        public void ElfoVidaTest()
        {
            Elfo elfo = new Elfo("Pedro", 10);
            int vidaEsperada = 100;

            int vida = elfo.ObtenerVida();

            Assert.AreEqual(vidaEsperada, vida);

        }

        [Test]
        public void ElfoCurarTest()
        {
            Elfo elfo = new Elfo("Pedro", 10);
            Heroe heroe = new Heroe();

            int vidaInicial = heroe.Vida; // guarda la vida inicial
            int curacionEsperada = elfo.Curacion;
            int vidaCurada = elfo.Curar(heroe); // realiza la curación

            Assert.AreEqual(vidaInicial + curacionEsperada, vidaCurada); // verifica que la vida haya incrementado la cantidad de curación esperada
        }

        [Test]
        public void ElfoAgregarElementoTest()
        {
            Elfo elfo = new Elfo("Pedro", 10);
            Lanza lanza = new Lanza(10, 5);

            elfo.AgregarElemento(lanza);

            Assert.Contains(lanza, elfo.Elementos);
        }

        [Test]
        public void ElfoQuitarElementoTest()
        {
            Elfo elfo = new Elfo("Pedro", 10);
            Lanza lanza = new Lanza(10, 5);
            elfo.AgregarElemento(lanza);

            elfo.QuitarElemento(lanza);

            Assert.IsFalse(elfo.Elementos.Contains(lanza));
        }
    }
}