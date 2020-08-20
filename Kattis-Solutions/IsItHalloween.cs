using System;

namespace Is_It_Halloween
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            if(s.Equals("OCT 31") || s.Equals("DEC 25"))
            {
                Console.WriteLine("yup");
            }
            else
            {
                Console.WriteLine("nope");
            }
        }
    }
}
