using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

using PingPong.Models;

namespace PingPong.Tests
{
  [TestClass]
  public class PingPongGeneratorTests
  {
    [TestMethod]
    public void PingPongGenerator_ConstructorSetsNumber_True()
    {
      PingPongGenerator newPong = new PingPongGenerator(5);
      int result = newPong.GetPingPongNumber();
      Assert.AreEqual(result, 5);
    }

    [TestMethod]
    public void GetNumberArr_CreatesArray_True()
    {
      PingPongGenerator newPong = new PingPongGenerator(5);
      List<int> result = newPong.GetNumberArr();
      CollectionAssert.AreEqual(result, new List<int>(){1,2,3,4,5});
    }

    [TestMethod]
    public void ChangeNumberToString_ChangesToString_True()
    {
      PingPongGenerator newPong = new PingPongGenerator(5);
      Assert.AreEqual("Ping-pong", newPong.ChangeNumberToString(15));
      Assert.AreEqual("Ping", newPong.ChangeNumberToString(3));
      Assert.AreEqual("Pong", newPong.ChangeNumberToString(5));
      Assert.AreEqual("7", newPong.ChangeNumberToString(7));
    }

    [TestMethod]
    public void DoPingPong_Combine_GetNumberArr_ChangeNumberToString_True()
    {
      List<string> newResult = new List<string>(){"1","2","Ping","4","Pong","Ping"};
      PingPongGenerator newPong = new PingPongGenerator(5);
      List<int> numArr = newPong.GetNumberArr();
      List<string> stringActual = newPong.DoPingPong(numArr);
      Assert.AreEqual(newResult, stringActual);
    }

  }
}
