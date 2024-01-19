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
      int expectedBreadPrice = 5;
      Order newOrder = new Order(expectedBreadPrice, 2);
      int result = newOrder.BreadPrice;
      Assert.AreEqual(expectedBreadPrice, result);
    }

    [TestMethod]
    public void SetBreadPrice_SetsValueOfBreadPrice_Void()
    {
      Order newOrder = new Order(5, 2);
      int newBreadPrice = 10;
      newOrder.BreadPrice = newBreadPrice;
      Assert.AreEqual(newBreadPrice, newOrder.BreadPrice);
    }

    [TestMethod]
    public void GetPastryPrice_ReturnsPastryPrice_Int()
    {
      int expectedPastryPrice = 2;
      Order newOrder = new Order(5, expectedPastryPrice);
      int result = newOrder.PastryPrice;
      Assert.AreEqual(expectedPastryPrice, result);
    }

    [TestMethod]
    public void SetPastryPrice_SetsValueOfPastryPrice_Void()
    {
      Order newOrder = new Order(5, 2);
      int newPastryPrice = 4;
      newOrder.PastryPrice = newPastryPrice;
      Assert.AreEqual(newPastryPrice, newOrder.PastryPrice);
    }
  }
}