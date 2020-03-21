using System;
using System.Collections.Generic;
using System.Linq;

namespace SquaredRandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            Random _rng = new Random();

            var randoms = new List<int>();
            var squaredRandoms = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                randoms.Add(_rng.Next(1, 50));
            }

            foreach (var num in randoms)
            {
                squaredRandoms.Add(num * num);
            }

            var oddSquaredRandoms = squaredRandoms.Where(square => (square % 2 != 0)).ToList();

            foreach (var oddNum in oddSquaredRandoms)
            {
                squaredRandoms.Remove(oddNum);
            }
        }
    }
}
