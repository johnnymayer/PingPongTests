using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace PingPong.Models
{
  public class PingPongGenerator
  {
    private int _pingPongNumber;
    private static List<int> _numberArr = new List<int> {};

    public PingPongGenerator(int pingPongNumber)
    {
      _pingPongNumber = pingPongNumber;
    }

    public int GetPingPongNumber()
    {
      return _pingPongNumber;
    }

    public void SetPingPongNumber(int pingPongNumber)
    {
      _pingPongNumber = pingPongNumber;
    }

    public List<int> GetNumberArr()
    {
      List<int> numberArr = new List<int>();
      for (int i = 1; i <= _pingPongNumber; i++)
      {
      numberArr.Add(i);
      }
      return numberArr;
    }

    public string ChangeNumberToString(int currentNum)
    {
      if (currentNum % 3 == 0 && currentNum % 5 == 0)
      {
          return ("Ping-pong");
      }
      else if (currentNum % 3 == 0)
      {
          return ("Ping");
      }
      else if (currentNum % 5 == 0)
      {
        return ("Pong");
      }
      else
      {
        return Convert.ToString(currentNum);
      }
    }

    public List<string> DoPingPong(List<int> numberArr)
    {
      List<string> resultList = new List<string>(){};
      for (int i = 1; i <= numberArr.Count; i++)
      {
        string singleResult = ChangeNumberToString(i);
        resultList.Add(singleResult);
      }
      return resultList;
    }
  }
}
