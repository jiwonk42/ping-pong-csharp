using System;
using System.Collections.Generic;

namespace PingPongGenerator
{
  public class PingPong
  {
    public List<string> PingPongGenerator(int number)
    {
      List<string> pingPongList = new List<string> {};

      for (int i = 1; i <= number; i++)
      {
        if (i % 3 == 0)
        {
          pingPongList.Add("ping");
        }
        else
        {
          pingPongList.Add(i.ToString());
        }
      }
      return pingPongList;
    }

    // public static void DeleteAll()
    // {
    //
    // }
  }
}
