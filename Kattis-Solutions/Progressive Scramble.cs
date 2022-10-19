using System;

namespace Progressive_Scramble
{
    class Program
    {
        static string encode(string s)
        {
            string result = "";
            s = s.Substring(2).ToLower();
            char[] sc = s.ToCharArray();
            int[] isc = new int[sc.Length];
            int[] aisc = new int[sc.Length];
            int temp;
            
            for (int i = 0; i < sc.Length; i++) { if (sc[i] == ' ') { isc[i] = 0; } else { isc[i] = ((int)sc[i] - 96); } }
            for (int i = 0; i < sc.Length; i++) { if (i == 0) { aisc[i] = isc[i]; } else { aisc[i] = aisc[i - 1] + isc[i]; } }
            for (int i = 0; i < sc.Length; i++) { temp = aisc[i] % 27; if (temp == 0) { sc[i] = ' '; } else { temp += 96; sc[i] = (char)temp; } }
            
            result = new string(sc);
            return result;
        }

        static int getrealvalue(int multcount, int x)
        {
            return (multcount * 27) + x;
        }

        static string decode(string s)
        {
            string result = "";
            int temp;
            s = s.Substring(2).ToLower();
            char[] asciisc = s.ToCharArray();
            int[] moddedasciisc = new int[asciisc.Length];
            int[] unmoddedasciisc = new int[asciisc.Length];
            int[] real = new int[asciisc.Length];
            int[] asciireal = new int[asciisc.Length];
            for (int i = 0; i < asciisc.Length; i++) { temp = (int)asciisc[i]; if (temp == 32) { moddedasciisc[i] = 0; } else { moddedasciisc[i] = temp - 96; } }
            int multcount = 0;
            for (int i = 0; i < asciisc.Length; i++)
            {
                if (i > 0)
                {
                    if (moddedasciisc[i] < moddedasciisc[i - 1]) { multcount++; }
                }
                unmoddedasciisc[i] = getrealvalue(multcount, moddedasciisc[i]);
            }
            for (int i = 0; i < asciisc.Length; i++) { if (i == 0) { real[i] = unmoddedasciisc[i]; } else { real[i] = unmoddedasciisc[i] - unmoddedasciisc[i - 1]; } }
            for(int i = 0; i < asciisc.Length; i++) { if (real[i] == 0) { real[i] = 32; } else { real[i] += 96; } }
            char[] final = new char[asciisc.Length];
            for (int i = 0; i < asciisc.Length; i++) { final[i] = (char)real[i]; }
            result = new string(final);
            return result;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s;
            for(int x = 0; x < n; x++) 
            {
                s = Console.ReadLine();
                if (s.StartsWith("d")) { Console.WriteLine(decode(s)); } else { Console.WriteLine(encode(s)); }
            }
        }
    }
}
