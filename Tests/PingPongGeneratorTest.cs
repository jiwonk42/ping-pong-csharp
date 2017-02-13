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
      Assert.Equal(testPingPongList, testPingPongGenerator.CreatePingPong(1));
    }

    [Fact]
    public void PingPongGenerator_ForUserInput3_ping()
    {
      PingPong testPingPongGenerator = new PingPong();
      List<string> testPingPongList = new List<string> {"1", "2", "ping"};
      Assert.Equal(testPingPongList, testPingPongGenerator.CreatePingPong(3));
    }

    [Fact]
    public void PingPongGenerator_ForUserInput5_pong()
    {
      PingPong testPingPongGenerator = new PingPong();
      List<string> testPingPongList = new List<string> {"1", "2", "ping", "4", "pong"};
      Assert.Equal(testPingPongList, testPingPongGenerator.CreatePingPong(5));
    }

    [Fact]
    public void PingPongGenerator_ForUserInput15_pingPong()
    {
      PingPong testPingPongGenerator = new PingPong();
      List<string> testPingPongList = new List<string> {"1", "2", "ping", "4", "pong", "ping", "7", "8", "ping", "pong", "11", "ping", "13", "14", "ping-pong"};
      Assert.Equal(testPingPongList, testPingPongGenerator.CreatePingPong(15));
    }
  }
}
