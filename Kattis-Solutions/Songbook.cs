using System;
using System.Collections.Generic;

namespace SongBook
{
    class Program
    {
        static void Main(string[] args)
        {
            int nsec, nsong, totsong=0, csec=0;
            string[] sarr;
            List<int> songs;
            sarr = Console.ReadLine().Split(' ');
            nsec = int.Parse(sarr[0]) * 60;
            nsong = int.Parse(sarr[1]);
            sarr = Console.ReadLine().Split(' ');
            songs = new List<int>();
            for(int i = 0; i < nsong; i++) { songs.Add(int.Parse(sarr[i])); }
            songs.Sort();
            for (int i = 0; i < nsong; i++)
            {
                if (csec < nsec)
                {
                    if((csec + songs[i]) <= nsec)
                    {
                        csec += songs[i];
                        totsong += 1;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(csec);

        }
    }
}
