using Nancy;
using PingPongGenerator;
using System;
using System.Collections.Generic;

namespace PingPongGenerator
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Get["/ping-pong-list"] = _ =>
      {
        string number = Request.Query["user-input"];
        PingPong PingPongGenerator = new PingPong();
        List<string> result = PingPongGenerator.CreatePingPong(int.Parse(number));
        return View["ping_pong_list.cshtml", result];
      };
    }
  }
}
