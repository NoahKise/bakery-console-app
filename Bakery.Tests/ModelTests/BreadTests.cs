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
  }
}