using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueenAttack;

namespace QueenAttack.Tests
{
  [TestClass]
  public class QueenAttackTest
  {
    [TestMethod]
    public void Return_True()
    {
      //Eventual Tests
      Queen queen = new Queen();
      Assert.AreEqual(true, queen.Default());
    }
    [TestMethod]
    public void Return_X0_True()
    {
      //Eventual Tests
      Queen queen = new Queen();
      Assert.AreEqual(0, queen.GetX());
    }
    [TestMethod]
    public void Return_Y0_True()
    {
      //Eventual Tests
      Queen queen = new Queen();
      Assert.AreEqual(0, queen.GetY());
    }
    [TestMethod]
    public void Return_X2_True()
    {
      //Eventual Tests
      Queen queen = new Queen(2,3);
      Assert.AreEqual(2, queen.GetX());
    }
    [TestMethod]
    public void Return_Y3_True()
    {
      //Eventual Tests
      Queen queen = new Queen(2,3);
      Assert.AreEqual(3, queen.GetY());
    }

  }
}
