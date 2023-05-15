namespace Library.Test;

public class BastonMagicoTest
{
    public BastonMagico bastonMagico;

    [SetUp]
    public void SetUp()
    {
    }

    [Test]
    public void BastonMagicoConstructorTest()
    {
        bastonMagico = new BastonMagico(10, 10);

        Assert.IsNotNull(bastonMagico);
    }

    [Test]
    public void BastonMagicoAtaqueTest()
    {
        bastonMagico = new BastonMagico(10, 10);

        Assert.AreEqual(10, bastonMagico.Ataque);
    }

    [Test]
    public void BastonMagicoDefensaTest()
    {
        Assert.AreEqual(10, bastonMagico.Defensa);
    }
}
