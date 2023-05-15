namespace Library.Test;

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
        enano.AgregarElemento(new Hacha(10, 10));

        Assert.IsNotNull(enano);
    }

    [Test]
    public void EnanoDefensaTest()
    {

        Enano enano = new Enano("Carlos");
        enano.AgregarElemento(new Hacha(10, 10));


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
}