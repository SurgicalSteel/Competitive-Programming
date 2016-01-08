using System;
    class MainClass
    {
        struct wordmarker{ public string word; public bool marked;};
        public static void Main(string[] args)
        {
            string temp;
            int tc;

            temp = Console.ReadLine();
            int.TryParse(temp, out tc);
            for (int i = 0; i < tc; i++)
            {
                string word = Console.ReadLine();
                string[] arrs = word.Split();
                wordmarker[] wm = new wordmarker[arrs.Length];
                for(int x=0;x<arrs.Length;x++)
                {
                    wm[x].word=arrs[x];
                    wm[x].marked=false;
                }
                string sound = Console.ReadLine();
                while(sound!="what does the fox say?")
                {
                    string[] animalsound = sound.Split();
                    for(int j=0;j<wm.Length;j++)
                    {if(wm[j].word==animalsound[2]){wm[j].marked=true;}}
                    sound=Console.ReadLine();
                }
                int xi=0;
                for (int iter = 0; iter < wm.Length; iter++)
                {
                    if (!wm[iter].marked && xi == 0)
                    {Console.Write(wm[iter].word);xi++;}
                    else if (!wm[iter].marked && iter > 0)
                    {Console.Write(" " + wm[iter].word);}
                }
                Console.WriteLine("");
            }
        }
}
