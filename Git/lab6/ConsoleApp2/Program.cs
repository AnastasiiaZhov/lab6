using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Int32.Parse(Console.ReadLine());
            for (int i = 11; i <= num; i++)
            {
                PrintAllRequiredNumbers(i);
            }
            Console.ReadLine();
        }

        static int Reverse_number(int i)
        {
            int rev = 0;
            while (i > 0)
            {
                int dig = i % 10;
                rev = rev * 10 + dig;
                i = i / 10;
            }
            return rev;
        }

        static bool IsReverse(int rev, int i)
        {

            bool reg = false;
            if (i == rev)
                reg = true;
            return reg;
        }

        static void PrintAllRequiredNumbers(int i)
        {
            int rev;
            int rev2;
            rev = Reverse_number(i);
            if (IsReverse(rev, i) == true)
            {
                rev2 = Reverse_number(i * i);
                if (IsReverse(rev2, i * i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
