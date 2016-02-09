using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;
//submitted by Yuwono Bangun Nagoro a.k.a SurgicalSteel
//Finally I got AC on this problem...
namespace ImageDecodingKattis
{
    class MainClass
    {
        static string draw(bool statetitik, int num)
        {
            string result="";
            for (int i = 0; i < num; i++)
            {
                if (statetitik)
                {
                    result+=".";
                }
                else
                {
                    result+="#";
                }
            }
            return result;
        }
        public static void Main(string[] args)
        {
            int tc = int.Parse(Console.ReadLine());
            while (tc != 0)
            {
                bool statetitik;
                bool samasemua=true;
                int jmlsample=0;
                List<string>hasil=new List<string>();
                for (int i = 0; i < tc; i++)//read each row of single image file
                {
                    List<string> sarrin=new List<string>();
                    sarrin=Console.ReadLine().Split().ToList();
                    //for(int x=0;x<sarrin.Count;x++){Console.Write(" {0}",sarrin[x]);}
                    int jmlku = 0;
                    if (i == 0)//sample buat getdifferentpixels
                    {
                        for (int x = 1; x < sarrin.Count; x++)
                        {
                            jmlsample += (int.Parse(sarrin[x]));
                        }
                    }
                    else
                    {
                        for (int x = 1; x < sarrin.Count; x++)
                        {
                            jmlku += (int.Parse(sarrin[x]));
                        }
                    }
                    if ( i>0 &&jmlku != jmlsample)
                    {
                        samasemua = false;
                    }
                    
                    if(sarrin[0].Equals("#")){statetitik=false;}else{statetitik=true;}
                    int ctr = 1;
                    string build="";
                    while (ctr < sarrin.Count)
                    {
                        build+=draw(statetitik,int.Parse(sarrin[ctr]));
                        statetitik = (!statetitik);
                        ctr++;
                    }
                    hasil.Add(build);
                }
                for(int x=0;x<hasil.Count;x++)
                    {Console.WriteLine(hasil[x]);}
                if (!samasemua)
                {Console.WriteLine("Error decoding image");}
                tc = int.Parse(Console.ReadLine());
                if(tc!=0){Console.WriteLine("");}
            }
        }
    }
}
