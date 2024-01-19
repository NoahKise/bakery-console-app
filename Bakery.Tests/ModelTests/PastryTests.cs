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

    // // Example Collection Test
    // [TestMethod]
    // public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    // {
    //   // any necessary logic to prep for test; instantiating new classes, etc.
    //   // we can also use the arrange, act, assert organization in any test. 
    //   CollectionAssert.AreEqual(ExpectedResult, CodeToTest);
    // }
  }
}