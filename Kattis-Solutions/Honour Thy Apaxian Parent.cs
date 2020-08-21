using System;

namespace Honour_Thy_Apaxian_Parent
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ");
            string res = "";
            if (arr[0].EndsWith("e"))
            {
                res = arr[0] + "x" + arr[1];
            }else if (arr[0].EndsWith("a") || arr[0].EndsWith("i") || arr[0].EndsWith("o") || arr[0].EndsWith("u"))
            {
                res = arr[0].Substring(0, arr[0].Length - 1) + "ex" + arr[1];
            }else if (arr[0].EndsWith("ex"))
            {
                res = arr[0] + arr[1];
            }
            else
            {
                res = arr[0] + "ex" + arr[1];
            }
            Console.WriteLine(res);
        }
    }
}
