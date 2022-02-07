using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle
{
  [TestClass]
  public class LeapYearTests
  {
    [TestMethod]
    public void IsRealTriangle()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsTriangle(3,3,3));
    }

    [TestMethod]
    public void IsTriangle_Equilateral()
    {
      Triangle testEquilateral = new Triangle();
      Assert.AreEqual(true, testEquilateral.IsEquilateral(3,3,3));
    }
    [TestMethod]
    public void IsTriangle_Not_Equilateral()
    {
      Triangle testEquilateral = new Triangle();
      Assert.AreEqual(false, testEquilateral.IsEquilateral(4,3,1));
    }
    [TestMethod]
    public void IsTriangle_Isosceles()
    {
      Triangle testIsosceles = new Triangle();
      Assert.AreEqual(true, testIsosceles.IsIsosceles(2,2,4));
    }
  }
}