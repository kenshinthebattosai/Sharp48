﻿using System;
using System.IO;
using Sharp48.Solvers;
using Sharp48.UserInterfaces;

namespace Sharp48.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var driverPath = Path.Combine(Environment.CurrentDirectory);
            var ui = new GoogleChromeUI(driverPath);
            var solver = new RandomSolver();
            using (var runner = new GameRunner(ui, solver))
                runner.Run();
            Console.WriteLine("Game Over");
            Console.ReadLine();
        }
    }
}