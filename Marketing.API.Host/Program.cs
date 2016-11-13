﻿using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketing.API.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Marketing.API.Host";
            string baseAddress = "http://localhost:20188/";

            using(WebApp.Start<Startup>(url: baseAddress))
            {
                Console.WriteLine();
                Console.WriteLine($"{Console.Title}: {baseAddress}");
                Console.ReadLine();
            }
        }
    }
}
