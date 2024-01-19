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

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order(5, 2);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetBreadPrice_ReturnsBreadPrice_Int()
    {
      // Arrange
      int expectedBreadPrice = 5;
      Order newOrder = new Order(expectedBreadPrice, 2);
      // Act
      int result = newOrder.BreadPrice;
      // Assert
      Assert.AreEqual(expectedBreadPrice, result);
    }
  }
}