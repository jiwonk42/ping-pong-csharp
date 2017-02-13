using Xunit;
using System;
using System.Collections.Generic;

namespace PingPongGenerator
{
  public class PingPongTest
  {
    [Fact]
    public void PingPongGenerator_ForUserInput1_1()
    {
      PingPong testPingPongGenerator = new PingPong();
      List<string> testPingPongList = new List<string> {"1"};
      Assert.Equal(testPingPongList, testPingPongGenerator.PingPongGenerator(1));
    }

    [Fact]
    public void PingPongGenerator_ForUserInput3_ping()
    {
      PingPong testPingPongGenerator = new PingPong();
      List<string> testPingPongList = new List<string> {"1", "2", "ping"};
      Assert.Equal(testPingPongList, testPingPongGenerator.PingPongGenerator(3));
    }

    // public void Dispose()
    // {
    //   PingPong.DeleteAll();
    // }
  }
}
