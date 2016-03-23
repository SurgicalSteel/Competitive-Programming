using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preludes
{
    class Program
    {
        struct fuck
        {
            public fuck(string n, string t)
            {
                this.note = n;this.tone = t;
            }
            public string note, tone;
        }
        static string getalternate(string s)
        {
            string ret;
            switch (s)
            {
                case "Ab": ret = "G#"; break;
                case "Bb": ret = "A#"; break;
                case "Db": ret = "C#"; break;
                case "Eb": ret = "D#"; break;
                case "Gb": ret = "F#"; break;
                case "G#": ret = "Ab"; break;
                case "A#": ret = "Bb"; break;
                case "C#": ret = "Db"; break;
                case "D#": ret = "Eb"; break;
                case "F#": ret = "Gb"; break;
                default  : ret = "no"; break;
            }
            return ret;
        }
        static void Main(string[] args)
        {
            /*
            A♭ minor D♯ major A♯ major D♯ minor A♯ minor G♭ major C♯ major G♭ minor D♭ minor G♯ major
            */
            List<fuck> lf = new List<fuck>();
            lf.Add(new fuck("Ab", "minor"));
            lf.Add(new fuck("D#", "major"));
            lf.Add(new fuck("A#", "major"));
            lf.Add(new fuck("D#", "minor"));
            lf.Add(new fuck("A#", "minor"));
            lf.Add(new fuck("Gb", "major"));
            lf.Add(new fuck("C#", "major"));
            lf.Add(new fuck("Gb", "minor"));
            lf.Add(new fuck("Db", "minor"));
            lf.Add(new fuck("G#", "major"));
            int tc = 1;
            string inp=Console.ReadLine();
            while (!string.IsNullOrEmpty(inp))
            {
                string[] inparr = inp.Split();
                fuck temp = new fuck(inparr[0], inparr[1]);
                if (lf.Exists(x => (x.tone == temp.tone) && (x.note == temp.note)))
                {
                    temp.note = getalternate(temp.note);
                    Console.WriteLine("Case {0}: {1} {2}", tc, temp.note, temp.tone);
                }
                else
                {
                    if (getalternate(temp.note).Equals("no"))
                    {
                        Console.WriteLine("Case {0}: UNIQUE",tc);
                    }
                    else
                    {
                        temp.note = getalternate(temp.note);
                        Console.WriteLine("Case {0}: {1} {2}", tc, temp.note, temp.tone);
                    }
                }
                tc++;
                inp = Console.ReadLine();
            }
        }
    }
}
