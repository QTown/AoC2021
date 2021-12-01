using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2021.Days
{
    public class Day01
    {
        private readonly int[] _input;

        public Day01()
        {
            _input = Common.ReadFile("day01.txt").Select(x => int.Parse(x)).ToArray();
        }

        public void Process()
        {
            Console.WriteLine($"Part 1: {GetIncreases()}");
            Console.WriteLine($"Part 2: {GetGroupedIncreases()}");
        }

        private int GetIncreases()
        {
            return GetIncreases(_input);
        }

        private int GetIncreases(int[] input)
        {
            return input.Select((x, i) => i < input.Length - 1 && input[i + 1] > input[i]).Count(x => x);
        }

        private int GetGroupedIncreases()
        {
            return GetIncreases(_input.Select((x, i) => i < _input.Length -2 ? _input[i..(i + 3)].Sum() : 0).ToArray());
        }
    }
}
