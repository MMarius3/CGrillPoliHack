using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PoliHack.Models;
using PoliHack.Service;

namespace PoliHack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

            // Dijsktra.Run();
            //Dijkstra.TestDijsktra();
            // DifferenceBetweenShortestAndSecondShortestPath.Run();
            // List<Line> lines = new List<Line>();
            // Line line = new Line((0, 0), (0, 0), (1, 2), (1, 2), "Name", false, (1, 2));
            // lines.Add(line);
            // line.Cost = (100, 100);
            //
            //     Console.WriteLine( lines.ElementAt(0).Cost);

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}
