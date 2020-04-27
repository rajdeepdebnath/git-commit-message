using System;

namespace git_commit_message
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1,2));
            Console.WriteLine(Add(1.5,2.7));
            Console.WriteLine(Add(1,2,3,4,5));
            Console.WriteLine(Subtraction(2,1));
        }
        static int Add(int a, int b)
        {
            return a+b;
        }
        static int Add(params int[] values)
        {
            var result = 0;

            if(values.Length > 1000000)
            {
                Console.WriteLine("The system do not support a million values because of resource limit!");
                throw new Exception("Million values not supported.");
            }

            foreach(var v in values)
            {
                result += v;
            }
            return result;
        }
        static double Add(double a, double b)
        {
            return a+b;
        }
        static int Subtraction(int a, int b)
        {
            return a-b;
        }
    }
}
