using System;
using New;
namespace JenkinsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of b");
            int b = Convert.ToInt32(Console.ReadLine());
            MyMaths math = new MyMaths();
            Console.WriteLine("Addition = " + math.add(a, b));
            Console.WriteLine("Multiplication = " + math.add(a, b));
        }
    }
}
