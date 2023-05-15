namespace Library.Test;

public class LanzaTest
{
    public LanzaTest lanza;

    [SetUp]
    public void SetUp()
    {
    }

    [Test]
    public void LanzaConstructorTest()
    {
        lanza = new Lanza(10, 10);

        Assert.IsNotNull(lanza);
    }

    [Test]
    public void LanzaAtaqueTest()
    {
        lanza = new Lanza(10, 10);

        Assert.AreEqual(10, lanza.Ataque);
    }

    [Test]
    public void LanzaDefensaTest()
    {
        Assert.AreEqual(10, lanza.Defensa);
    }
}
