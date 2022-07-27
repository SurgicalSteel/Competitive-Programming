using System;

namespace Ultimate_Binary_Watch
{
    class Program
    {
        static string translateToBinary(int x)
        {
            string result = "";
            for (int i = 3; i >= 0; i--) {
                if(x >= (int) Math.Pow(2, i))
                {
                    result += "*";
                    x -= (int) Math.Pow(2, i);
                }
                else
                {
                    result += ".";
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] arr = new string[9];
            arr[0] = translateToBinary(int.Parse(s.Substring(0, 1)));
            arr[1] = "    ";
            arr[2] = translateToBinary(int.Parse(s.Substring(1, 1)));
            arr[3] = "    ";
            arr[4] = "    ";
            arr[5] = "    ";
            arr[6] = translateToBinary(int.Parse(s.Substring(2, 1)));
            arr[7] = "    ";
            arr[8] = translateToBinary(int.Parse(s.Substring(3, 1)));
            
            for(int i = 0; i <4; i++)
            {
                s = "";
                for(int x =0; x < 9; x++)
                {
                    s += arr[x].Substring(i, 1);
                }
                Console.WriteLine(s);
            }
        }
    }
}

