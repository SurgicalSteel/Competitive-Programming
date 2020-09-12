using System;

namespace The_Easiest_Problem_Is_This_One
{
    class Program
    {
        static int getSumDigit(int x)
        {
            if (x <= 0) { return 0; }
            int sum = 0,tmpmod=0;
            while (x > 0)
            {
                tmpmod = x % 10;
                sum += tmpmod;
                x -= tmpmod;
                x /= 10;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int tempSum, pointer ;
            bool found;
            while (x > 0)
            {
                pointer = 11;
                found = false;
                tempSum = getSumDigit(x);
                while (!found)
                {
                    if(getSumDigit(pointer * x) == tempSum)
                    {
                        found = true;
                    }
                    else
                    {
                        pointer++;
                    }
                }
                Console.WriteLine(pointer);
                x = int.Parse(Console.ReadLine());
            }
        }
    }
}
