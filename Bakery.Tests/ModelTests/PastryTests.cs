using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
     public void PricePastry_ReturnsAnInt_Int()
    {
      Pastry newPastry = new Pastry(1); 
      int pastryPrice = newPastry.PricePastry();
      Assert.IsInstanceOfType(pastryPrice, typeof(int));
    }

    [TestMethod]
    public void PricePastry_Returns4IfInput2_Int()
    {
      Pastry newPastry = new Pastry(2); 
      int expectedPrice = 4;
      int actualPrice = newPastry.PricePastry();
      Assert.AreEqual(expectedPrice, actualPrice);
    }

    [TestMethod]
    public void PricePastry_Returns6IfInput4_Int()
    {
      Pastry newPastry = new Pastry(4); 
      int expectedPrice = 6;
      int actualPrice = newPastry.PricePastry();
      Assert.AreEqual(expectedPrice, actualPrice);
    }

    [TestMethod]
    public void PriceBread_Returns12IfInput7_Int()
    {
      Pastry newPastry = new Pastry(7); 
      int expectedPrice = 12;
      int actualPrice = newPastry.PricePastry();
      Assert.AreEqual(expectedPrice, actualPrice);
    }

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(2);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetQuantity_ReturnsQuantity_Int()
    {
      int expectedQuantity = 5;
      Pastry newPastry = new Pastry(expectedQuantity);
      int result = newPastry.Quantity;
      Assert.AreEqual(expectedQuantity, result);
    }

    [TestMethod]
    public void SetQuantity_SetsValueOfQuantity_Void()
    {
      Pastry newPastry = new Pastry(5);
      int newQuantity = 10;
      newPastry.Quantity = newQuantity;
      Assert.AreEqual(newQuantity, newPastry.Quantity);
    }
  }
}