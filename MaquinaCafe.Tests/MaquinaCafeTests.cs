using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaquinaCafe;

namespace MaquinaCafe.Tests;

[TestClass]
public class MaquinaCafeTests
{
    [TestMethod]
    public void CafePequeno()
    {
        var m = new MaquinaCafe(new Cafetera(20), new Vasos(5), new Azucarero(10));
        Assert.AreEqual("Café listo", m.PrepararCafe(3,1));
    }

    [TestMethod]
    public void CafeMediano()
    {
        var m = new MaquinaCafe(new Cafetera(20), new Vasos(5), new Azucarero(10));
        Assert.AreEqual("Café listo", m.PrepararCafe(5,1));
    }

    [TestMethod]
    public void CafeGrande()
    {
        var m = new MaquinaCafe(new Cafetera(20), new Vasos(5), new Azucarero(10));
        Assert.AreEqual("Café listo", m.PrepararCafe(7,1));
    }

    [TestMethod]
    public void SinVasos()
    {
        var m = new MaquinaCafe(new Cafetera(20), new Vasos(0), new Azucarero(10));
        Assert.AreEqual("No hay vasos", m.PrepararCafe(3,1));
    }

    [TestMethod]
    public void SinCafe()
    {
        var m = new MaquinaCafe(new Cafetera(0), new Vasos(5), new Azucarero(10));
        Assert.AreEqual("No hay café", m.PrepararCafe(3,1));
    }

    [TestMethod]
    public void SinAzucar()
    {
        var m = new MaquinaCafe(new Cafetera(20), new Vasos(5), new Azucarero(0));
        Assert.AreEqual("No hay azúcar", m.PrepararCafe(3,2));
    }
}
