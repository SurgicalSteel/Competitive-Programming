using System;

namespace This_Aint_Your_Grandpas_Checkerboard
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[][] m = new string[n][];
            string tempInput;
            for (int x = 0; x < n; x++) {
                m[x] = new string[n];
                tempInput = Console.ReadLine();
                for(int y = 0; y < tempInput.Length; y++)
                {
                    m[x][y] = tempInput.Substring(y, 1);
                }
            }
            bool valid = true;
            int countCW, countCB, countRW, countRB;

            for (int j = 0; j < n; j++)
            {
                countCB = 0;
                countCW = 0;
                for (int i = 0; i < n; i++)
                {
                    if (m[j][i] == "W") { countCW++; } else { countCB++; }
                    if (n >= 3)
                    {
                        if (i > 0 && i < n - 1)
                        {
                            if(m[j][i-1] == m[j][i] && m[j][i] == m[j][i + 1]) { valid = false; }
                        }
                    }
                }
                valid = ((countCB == countCW) && valid);
            }

            if (!valid)
            {
                Console.WriteLine("0");
                return;
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    countRB = 0;
                    countRW = 0;
                    for (int j = 0; j < n; j++)
                    {
                        if (m[j][i] == "W") { countRW++; } else { countRB++; }
                        if (n >= 3)
                        {
                            if (j > 0 && j < n - 1)
                            {
                                if (m[j - 1][i] == m[j][i] && m[j][i] == m[j + 1][i]) { valid = false; }
                            }
                        }
                    }
                    valid = ((countRW == countRB) && valid);
                }
                if (!valid)
                {
                    Console.WriteLine("0");
                    return;
                }
                else
                {
                    Console.WriteLine("1");
                    return;
                }
            }


        }
    }
}
