using System;

namespace Filip
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = Console.ReadLine();
            String[] arr = s.Split(" ");
            String a = Reverse(arr[0]);
            String b = Reverse(arr[1]);
            for(int i = 0; i < 3; i++)
            {
                int ta = int.Parse(a.Substring(i, 1));
                int tb = int.Parse(b.Substring(i, 1));
                if (ta > tb)
                {
                    Console.WriteLine(a);
                    break;
                }else if(tb > ta)
                {
                    Console.WriteLine(b);
                    break;
                }
            }
        }
        static string Reverse(string s)
        {
            String r = "";
            for(int i = s.Length - 1; i >= 0; i--) {
                r += s.Substring(i, 1);
            }
            return r;
        }
    }
}
