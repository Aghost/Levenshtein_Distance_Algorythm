using System;
using Levenshtein.Business;

using static System.Console;

namespace Levenshtein.App
{
    class Program
    {
        static void Main(string[] args) {
            if (args.Length > 1) {
                WriteLine(LevenshteinAlgo.Algo(args[0], args[1]));
            } else {
                WriteLine("Argument error...");
            }
        }
    }
}
