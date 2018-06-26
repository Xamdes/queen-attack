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
      Assert.AreEqual(false, queen.Default());
    }

  }
}
