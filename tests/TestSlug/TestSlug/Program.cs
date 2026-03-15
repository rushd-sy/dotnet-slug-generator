using System;
using SlugGenerator;

namespace SlugGenerator {
    public class Program
    {
        public static void Main(string[] args)
        {
            string test = Console.ReadLine();
            Console.WriteLine(SlugGenerator.GenerateSlug(test));

        }
    }
}