using System;
namespace DemoArrays
{
    class Program
    { 
    static void Main(string[] args)
        {
            var numbers = new[] { 3, 4, 7, 12, 14, 6 };
            //Lentgh 
            Console.WriteLine($"length: {numbers.Length}");
            //indexof()
            var index = Array.IndexOf(numbers, 12);
            Console.WriteLine($"index of 12 is {index}");
            //Clear()
            Array.Clear(numbers, 0, 3);
            Console.WriteLine("Effect of Clear()");
            foreach(var number in numbers )
            {
                Console.WriteLine(number);
            }
            //Copy()
            var another = new int[4];
            Array.Copy(numbers, another, 4);
            Console.WriteLine("Effect of Copy()");
            foreach(var number in another )
            {
                Console.WriteLine(number);
            }
            //Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort()");
                foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }
            //Reverse
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse()");
                foreach(var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
