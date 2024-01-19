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
      int pastryPrice = Pastry.PricePastry(1);
      Assert.IsInstanceOfType(pastryPrice, typeof(int));
    }

    [TestMethod]
    public void PricePastry_Returns4IfInput2_Int()
    {
      int expectedPrice = 4;
      int actualPrice = Pastry.PricePastry(2);
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