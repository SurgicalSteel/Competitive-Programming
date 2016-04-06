using System;
using System.Text;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
namespace myCSharpTemplate
{
    class MainClass
    {
        static string eliminateAt(string x, int num)//eliminates a single substring of a string in a given position
        {
            if(num==0){return x.Substring(1,x.Length-1);}
            else if(num==x.Length-1){return x.Substring(0,x.Length-1);}
            else{return x.Substring(0,num)+x.Substring(num+1,x.Length-1);}
        }
        public static void Main()
        {
            string str=Console.ReadLine();
            int i=0;
            int ln=str.Length;
            string build="";
            while(i<ln)
            {
                if(str.Substring(i,1).Equals("a")||str.Substring(i,1).Equals("i")||str.Substring(i,1).Equals("u")||str.Substring(i,1).Equals("e")||str.Substring(i,1).Equals("o"))
                {build+=str.Substring(i,1);i+=3;}else
                {   build+=str.Substring(i,1);
                    i++;}
            }
            Console.WriteLine(build);
        }
    }
}
