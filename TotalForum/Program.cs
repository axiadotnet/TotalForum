using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using TotalForum.Model;

namespace TotalForum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Post post1 = new Post(1, "Post1", "Ciao sono il primo post", DateTime.Now, 5);
            Console.WriteLine(post1);
            CreateHostBuilder(args).Build().Run();
            
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
