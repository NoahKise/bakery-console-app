using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void PriceBread_ReturnsAnInt_Int()
    {
      int breadPrice = Bread.PriceBread(1);
      Assert.IsInstanceOfType(breadPrice, typeof(int));
    }

    [TestMethod]
    public void PriceBread_Returns10IfInput2_Int()
    {
      int expectedPrice = 10;
      int actualPrice = Bread.PriceBread(2);
      Assert.AreEqual(expectedPrice, actualPrice);
    }

    [TestMethod]
    public void PriceBread_Returns10IfInput3_Int()
    {
      int expectedPrice = 10;
      int actualPrice = Bread.PriceBread(3);
      Assert.AreEqual(expectedPrice, actualPrice);
    }
    
    [TestMethod]
    public void PriceBread_Returns15IfInput4_Int()
    {
      int expectedPrice = 15;
      int actualPrice = Bread.PriceBread(4);
      Assert.AreEqual(expectedPrice, actualPrice);
    }
  }
}