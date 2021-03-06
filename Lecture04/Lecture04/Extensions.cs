﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lecture04
{
    public static class Extensions
    {
        public static void Print<T>(this T stuff, int depth = 0)
        {
            switch (stuff)
            {
                case string str:
                    Console.WriteLine($"{string.Concat(Enumerable.Repeat('-', depth))} {str}");
                    break;
                case IEnumerable<int> numbers:
                    Console.WriteLine(string.Join(", ", numbers));
                    break;
                case IEnumerable items:
                    foreach (var item in items)
                    {
                        Print(item, depth + 1);
                    }
                    break;
                default:
                    Console.WriteLine($"{string.Concat(Enumerable.Repeat('-', depth))} {stuff}");
                    break;
            }
        }
    }
}
