using System;

public class Test
{
    static string getlast(string s)
    {
        if(s=="a"||s=="b"||s=="c"){return "2";}
        else if(s=="d"||s=="e"||s=="f"){return "3";}
        else if(s=="g"||s=="h"||s=="i"){return "4";}
        else if(s=="j"||s=="k"||s=="l"){return "5";}
        else if(s=="m"||s=="n"||s=="o"){return "6";}
        else if(s=="p"||s=="q"||s=="r"||s=="s"){return "7";}
        else if(s=="t"||s=="u"||s=="v"){return "8";}
        else if(s=="w"||s=="x"||s=="y"||s=="z"){return "9";}
        else if(s==" "){return "0";}
        else{return " ";}
    }
    static string translate(string s)
    {
        switch (s)
        {
            case "a":{return "2";}
            case "b":{return "22";}
            case "c":{return "222";}
            case "d":{return "3";}
            case "e":{return "33";}
            case "f":{return "333";}
            case "g":{return "4";}
            case "h":{return "44";}
            case "i":{return "444";}
            case "j":{return "5";}
            case "k":{return "55";}
            case "l":{return "555";}
            case "m":{return "6";}
            case "n":{return "66";}
            case "o":{return "666";}
            case "p":{return "7";}
            case "q":{return "77";}
            case "r":{return "777";}
            case "s":{return "7777";}
            case "t":{return "8";}
            case "u":{return "88";}
            case "v":{return "888";}
            case "w":{return "9";}
            case "x":{return "99";}
            case "y":{return "999";}
            case "z":{return "9999";}
            case " ":{return "0";}
            default :{return " ";}
        }
    }
    static string solve(int icase, string word)
    {
        string build="";
        for(int i=0;i<word.Length;i++)
        {
            if(i==0){build+=translate(word.Substring(i,1));}
            else
            {
                if(getlast(word.Substring(i-1,1))==getlast(word.Substring(i,1)))
                {
                    build+=" ";
                    build+=translate(word.Substring(i,1));
                }
                else{build+=translate(word.Substring(i,1));}
            }
        }
        return "Case #"+icase.ToString()+": "+build;
    }
    public static void Main()
    {
        string inp;
        int n;
        inp=Console.ReadLine();
        int.TryParse(inp, out n);
        for(int i=0;i<n;i++)
        {
            inp=Console.ReadLine();
            Console.WriteLine(solve(i+1,inp));
        }
    }
}
