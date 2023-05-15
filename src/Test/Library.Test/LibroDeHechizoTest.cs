namespace Library.Test;

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
        libroDeHechizo = new LibroDeHechizo();
        libroDeHechizo.AgrgarHechizo("Hechizo1", 10, 10, 10);

        Assert.AreEqual(10, libroDeHechizo.Curacion);
        Assert.AreEqual(10, libroDeHechizo.Ataque);
        Assert.AreEqual(10, libroDeHechizo.Defensa);
    }

    [Test]
    public void LibroDeHechizoAgregarHechizoTest2()
    {
        libroDeHechizo = new LibroDeHechizo();
        libroDeHechizo.AgrgarHechizo("Hechizo1", 10, 10, 10);
        libroDeHechizo.AgrgarHechizo("Hechizo2", 10, 10, 10);

        Assert.AreEqual(20, libroDeHechizo.Curacion);
        Assert.AreEqual(20, libroDeHechizo.Ataque);
        Assert.AreEqual(20, libroDeHechizo.Defensa);
    }
}