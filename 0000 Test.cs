using System;

namespace Setup
{
    public class Test
    {
        static void Main(string[] args)
        {
            var sln = new Task20.Solution();

            Console.WriteLine(sln.IsValid("()()()"));
        }
    }
}