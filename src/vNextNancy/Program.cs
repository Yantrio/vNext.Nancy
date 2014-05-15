using System;
using System.Threading;
using System.Linq;
using Nancy;
using Nancy.Hosting.Self;


public class Program
{
    public static void Main()
    {
    	Console.WriteLine("Starting Nancy...");
        using (var host = new NancyHost(new Uri("http://localhost:1234")))
    		{
    		   host.Start();
    		   Console.ReadLine();
    		}
    }
}

public class SampleModule : NancyModule
  {
    public SampleModule()
    {
      Get["/"] = _ => "Hello World!";
    }
  }