using System;

namespace Calculating_Dart_Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());
            string res = "";
            for(int i=0; i<=3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    for (int k = 0; k <= 3; k++)
                    {
                        for (int ni = 1; ni <= 20; ni++)
                        {
                            for (int nj = 1; nj <= 20; nj++)
                            {
                                for (int nk = 1; nk <= 20; nk++)
                                {
                                    if(((i*ni)+(j*nj)+(k*nk)) == score)
                                    {
                                        res = CreateResultString(i, ni, j, nj, k, nk);
                                        break;
                                    } 
                                }
                            }
                        }
                    }
                }
            }
            if (res.Length == 0)
            {
                Console.WriteLine("impossible");
            }
            else
            {
                Console.Write(res);
            }
        }
        static string CreateResultString(int i, int ni, int j, int nj, int k, int nk)
        {
            string res = "";
            string li = CreateLineString(i, ni);
            string lj = CreateLineString(j, nj);
            string lk = CreateLineString(k, nk);
            if (li.Length > 0)
            {
                res += li;
                res += "\n";
            }
            if (lj.Length > 0)
            {
                res += lj;
                res += "\n";
            }
            if (lk.Length > 0)
            {
                res += lk;
                res += "\n";
            }
            return res;
        }
        static string CreateLineString(int i, int ni)
        {
            string res = "";
            switch (i)
            {
                case 1:
                    res += "single ";
                    break;
                case 2:
                    res += "double ";
                    break;
                case 3:
                    res += "triple ";
                    break;
                default:
                    return "";
            }
            res += ni.ToString();
            return res;
        }
    }
}
