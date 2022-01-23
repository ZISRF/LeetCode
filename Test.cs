using System;

namespace Setup
{
    public class Test
    {
        static void Main(string[] args)
        {
            var sln = new Task4.Solution();

            Console.WriteLine(sln.FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2, 4 }));
        }
    }
}