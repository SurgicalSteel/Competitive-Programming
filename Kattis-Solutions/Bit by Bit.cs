using System;

namespace Bit_By_Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr;
            string[] cmdArr;
            int pa, pb;
            while (n > 0)
            {
                arr = new int[32];
                for(int i = 0; i < 32; i++)
                {
                    arr[i] = -1;
                }

                for(int i = 0; i < n; i++)
                {
                    cmdArr = Console.ReadLine().Split(" ");
                    switch (cmdArr[0])
                    {
                        case "SET":
                            pa = int.Parse(cmdArr[1]);
                            arr[pa] = 1;
                            break;
                        case "CLEAR":
                            pa = int.Parse(cmdArr[1]);
                            arr[pa] = 0;
                            break;

                        case "OR":
                            pa = int.Parse(cmdArr[1]);
                            pb = int.Parse(cmdArr[2]);
                            arr[pa] = opOr(arr[pa], arr[pb]);
                            break;

                        case "AND":
                            pa = int.Parse(cmdArr[1]);
                            pb = int.Parse(cmdArr[2]);
                            arr[pa] = opAnd(arr[pa], arr[pb]);
                            break;
                    }
                }
                printArr(arr);
                n = int.Parse(Console.ReadLine());
            }



        }
        static int opAnd(int a, int b)
        {
            if (a == 1 && b == 1)
            {
                return 1;
            }
            if( a == 0 || b == 0 )
            {
                return 0;
            }
            return -1;
        }

        static int opOr(int a, int b)
        {
            if(a == 1 || b == 1)
            {
                return 1;
            }
            if( a == 0 && b == 0)
            {
                return 0;
            }
            return -1;
        }

        static void printArr(int[] arr)
        {
            string s = "";
            for(int i = arr.Length - 1; i >= 0; i--)
            {
                if(arr[i]== -1)
                {
                    s += "?";
                }
                else
                {
                    s += arr[i].ToString();
                }
            }
            Console.WriteLine(s);
        }
    }
}
