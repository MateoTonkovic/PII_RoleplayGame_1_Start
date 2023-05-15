namespace Library.Test;

public class EspadaTest
{
    public EspadaTest espada;

    [SetUp]
    public void SetUp()
    {
    }

    [Test]
    public void EspadaConstructorTest()
    {
        espada = new Espada(10, 10);

        Assert.IsNotNull(espada);
    }

    [Test]
    public void EspadaAtaqueTest()
    {
        espada = new Espada(10, 10);

        Assert.AreEqual(10, espada.Ataque);
    }

    [Test]
    public void EspadaDefensaTest()
    {
        Assert.AreEqual(10, espada.Defensa);
    }
}
