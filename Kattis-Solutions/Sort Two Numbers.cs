using System;

namespace Sort_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sarr = Console.ReadLine().Split(' ');
            if (int.Parse(sarr[0]) > int.Parse(sarr[1])) { Console.WriteLine("{0} {1}", sarr[1], sarr[0]); }
            else { Console.WriteLine(string.Join(" ", sarr)); }
   
        }
    }
}
