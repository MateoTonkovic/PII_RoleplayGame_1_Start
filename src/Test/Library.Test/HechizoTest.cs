namespace Library.Test;

public class HechizoTest
{
    public Hechizo hechizo;

    [SetUp]
    public void SetUp()
    {
    }

    [Test]
    public void HechizoConstructorTest()
    {
        hechizo = new Hechizo("hechizo1", 10, 10, 10);

        Assert.IsNotNull(hechizo);
    }

    [Test]
    public void HechizoAtaqueTest()
    {
        hechizo = new Hechizo("hechizo1", 10, 10, 10);

        Assert.AreEqual(10, hechizo.Ataque);
    }

    [Test]
    public void HechizoDefensaTest()
    {
        Assert.AreEqual(10, hechizo.Defensa);
    }

    [Test]
    public void HechizoCuracionTest()
    {
        Assert.AreEqual(10, hechizo.Curacion);
    }

    [Test]
    public void HechizoNombreTest()
    {
        Assert.AreEqual("hechizo1", hechizo.Nombre);
    }

    [Test]
    public void HechizoNombreTest2()
    {
        hechizo = new Hechizo("hechizo2", 10, 10, 10);

        Assert.AreEqual("hechizo2", hechizo.Nombre);
    }

    [Test]
    public void HechizoAtaqueTest2()
    {
        hechizo = new Hechizo("hechizo2", 10, 10, 10);

        Assert.AreEqual(10, hechizo.Ataque);
    }
}