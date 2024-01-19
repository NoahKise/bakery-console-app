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
  }
}