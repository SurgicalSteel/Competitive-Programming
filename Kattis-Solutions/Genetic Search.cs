using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Solution
{
    class Solution
    {
        static string eliminateAt(string x, int num){
	    if(num==0){return x.Substring(1,x.Length-1);}
	    else if(num==x.Length-1){return x.Substring(0,x.Length-1);}
	    else{return x.Substring(0,num)+x.Substring(num+1,x.Length-num-1);}
        }
        static string insertAt(string s, string l, int pos){
            if (pos==0){return s+l;}
            else if(pos== l.Length){return l+s;}
            else{return l.Substring(0,pos)+s+l.Substring(pos,l.Length-pos);}
        }
        static int caThree(string s, string l){
            int c=0;
            List<string> ls = new List<string>();
            List<string> uls = new List<string>();
            string[] t = {"A","G","T","C"};
            for(int i=0;i<=s.Length;i++){
                for (int j=0;j<4;j++){
                    ls.Add(insertAt(t[j],s,i));
                }
            }
            uls = ls.Distinct().ToList();
            for(int i=0;i<uls.Count();i++){
                c+=numOc(uls.ElementAt(i),l);
            }
            return c;
        }
        static int caTwo(string s, string l){
            int c=0;
            string ts;
            List<string> ls=new List<string>();
            List<string> uls=new List<string>();
            for(int i=0;i<s.Length;i++){
                ts=eliminateAt(s,i);
                ls.Add(ts);
            }
            uls = ls.Distinct().ToList();
            for(int i=0;i<uls.Count();i++){
                c+= numOc(uls.ElementAt(i),l);
            }
            return c;
        }
        static int numOc(string s, string l){
            int c=0;
            for(int i=0;i<=l.Length-s.Length;i++){
                if (l.Substring(i,s.Length).Equals(s)){
                    c++;
                }
            }
            return c;
        }
        static string solve(string s, string l){
            int cs,cd,ct;
            cs=numOc(s,l);
            cd=caTwo(s,l);
            ct=caThree(s,l);
            return String.Format("{0} {1} {2}", cs,cd,ct);
        }
        static void Main(string[] args)
        {
            //Your code goes here
            string w,s,l;
            w=Console.ReadLine();
            while(w!="0"){
                if (w=="0"){break;}
                string[] aw = w.Split();
                s=aw[0];
                l=aw[1];
                Console.WriteLine(solve(s,l));
                w=Console.ReadLine();
            }
        }
    }
}
