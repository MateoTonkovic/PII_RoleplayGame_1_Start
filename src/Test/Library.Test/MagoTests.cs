namespace Library.Test;

public class MagoTest
{
    public Mago mago;

    [SetUp]
    public void SetUp()
    {
    }

    [Test]
    public void MagoConstructorTest()
    {
        mago = new Mago("Juan");

        Assert.IsNotNull(mago);
    }

    [Test]
    public void MagoDefensaTest()
    {
        Assert.AreEqual(10, mago.Defensa);
    }

    [Test]
    public void MagoVidaTest()
    {
        Assert.AreEqual(100, mago.Vida);
    }

    [Test]
    public void MagoNombreTest()
    {
        Assert.AreEqual("Juan", mago.Nombre);
    }

    [Test]
    public void MagoNombreTest2()
    {
        mago = new Mago("Pedro");

        Assert.AreEqual("Pedro", mago.Nombre);
    }
}