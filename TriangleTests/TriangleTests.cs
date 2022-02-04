using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle
{
  [TestClass]
  public class LeapYearTests
  {
    [TestMethod]
    public void IsTriangle_Equilateral()
    {
      Triangle testEquilateral = new Triangle();
      Assert.AreEqual(true, testEquilateral.IsEquilateral(3,3,3));
    }
  }
}