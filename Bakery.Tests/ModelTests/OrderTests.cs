using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void CalculateTotal_ReturnsAnInt_Int()
    {
      int breadPrice = Order.CalculateTotal(1, 1);
      Assert.IsInstanceOfType(breadPrice, typeof(int));
    }
    [TestMethod]
    public void PriceBread_Returns7WithInputs5And2_Int()
    {
      int expectedPrice = 7;
      int actualPrice = Order.CalculateTotal(5, 2);
      Assert.AreEqual(expectedPrice, actualPrice);
    }
  }
}