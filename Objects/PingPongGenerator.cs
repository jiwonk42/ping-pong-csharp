using System;
using System.Collections.Generic;

namespace PingPongGenerator
{
  public class PingPong
  {
    public List<string> CreatePingPong(int number)
    {
      List<string> pingPongList = new List<string> {};

      for (int i = 1; i <= number; i++)
      {
        if (i % 15 == 0)
        {
          pingPongList.Add("ping-pong");
        }
        else if (i % 3 == 0)
        {
          pingPongList.Add("ping");
        }
        else if (i % 5 == 0)
        {
          pingPongList.Add("pong");
        }
        else
        {
          pingPongList.Add(i.ToString());
        }
      }
      return pingPongList;
    }
  }
}
