using System;
using System.Collections.Generic;
namespace SMIL
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            List<int> list = new List<int>();
            for(int i = 0; i < line.Length; i++)
            {
                if(i<line.Length -1 && (line.Substring(i,2).Equals(":)") || line.Substring(i, 2).Equals(";)"))) 
                { 
                    list.Add(i); 
                }
                if (i < line.Length - 2 && (line.Substring(i, 3).Equals(":-)") || line.Substring(i, 3).Equals(";-)")))
                {
                    list.Add(i);
                }
            }
            for(int i = 0; i < list.Count; i++) { Console.WriteLine("{0}", list[i]); }
        }
    }
}
