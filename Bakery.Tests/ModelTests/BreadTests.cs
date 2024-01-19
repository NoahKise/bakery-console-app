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
      Bread newBread = new Bread(1); 
      int breadPrice = newBread.PriceBread();
      Assert.IsInstanceOfType(breadPrice, typeof(int));
    }

    [TestMethod]
    public void PriceBread_Returns10IfInput2_Int()
    {
      Bread newBread = new Bread(2); 
      int expectedPrice = 10;
      int actualPrice = newBread.PriceBread();
      Assert.AreEqual(expectedPrice, actualPrice);
    }

    [TestMethod]
    public void PriceBread_Returns10IfInput3_Int()
    {
      Bread newBread = new Bread(3); 
      int expectedPrice = 10;
      int actualPrice = newBread.PriceBread();
      Assert.AreEqual(expectedPrice, actualPrice);
    }

    [TestMethod]
    public void PriceBread_Returns15IfInput4_Int()
    {
      Bread newBread = new Bread(4); 
      int expectedPrice = 15;
      int actualPrice = newBread.PriceBread();
      Assert.AreEqual(expectedPrice, actualPrice);
    }

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(2);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetQuantity_ReturnsQuantity_Int()
    {
      int expectedQuantity = 5;
      Bread newBread = new Bread(expectedQuantity);
      int result = newBread.Quantity;
      Assert.AreEqual(expectedQuantity, result);
    }

    [TestMethod]
    public void SetQuantity_SetsValueOfQuantity_Void()
    {
      Bread newBread = new Bread(5);
      int newQuantity = 10;
      newBread.Quantity = newQuantity;
      Assert.AreEqual(newQuantity, newBread.Quantity);
    }
  }
}