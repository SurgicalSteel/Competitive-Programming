using System;

namespace ASCII_Kassi
{
    class Program
    {

        static string bstb(int x)
        {
            string s = "+";
            for(int i = 0; i < x; i++)
            {
                s += "-";
            }
            s += "+";
            return s;
        }
        static string bsm(int x)
        {
            string s = "|";
            for (int i = 0; i < x; i++)
            {
                s += " ";
            }
            s += "|";
            return s;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine("++");
                Console.WriteLine("++");
            }
            else
            {
                string edge = bstb(n);
                string mid = bsm(n);
                Console.WriteLine(edge);
                for(int i = 0; i < n; i++) { Console.WriteLine(mid); }
                Console.WriteLine(edge);
            }
        }
    }
}
