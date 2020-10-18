using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Test
{
    public static void Main()
    {
        /*
            We were here
            Roaming on the endless prairie
            Writing an endless story
            Building a Walden of our own
            We were here
            Grieving the saddened faces
            Conquering the darkest places
            Time to rest now and to finish the show
            And become the music, one with alpenglow
            
            You are my path, my home, my star
            A beautiful tale within the tale
            And when the dust needs to move on
            I will tuck us in on a bed of snow
            Painting white, silencing the valley we built
            Together we'll sleep
            Devoured by life
        */
        string x, res = "";
        bool unknown_flag;
        int sum;
        Dictionary<string, int> dsi = new Dictionary<string, int>();
        Dictionary<int, string> dis = new Dictionary<int, string>();
        x = Console.ReadLine();
        while (!string.IsNullOrEmpty(x))
        {
            string[] xarr = x.Split();
            if (xarr[0].Equals("def"))
            {
                if (dsi.ContainsKey(xarr[1]))
                {
                    int temp = dsi[xarr[1]];
                    dsi.Remove(xarr[1]);
                    dis.Remove(temp);
                    dsi[xarr[1]] = int.Parse(xarr[2]);
                    dis[int.Parse(xarr[2])] = xarr[1];
                }
                else
                {
                    dsi.Add(xarr[1], int.Parse(xarr[2]));
                    dis.Add(int.Parse(xarr[2]), xarr[1]);
                }
            }
            else if (xarr[0].Equals("calc"))
            {
                sum = 0;
                unknown_flag = false;
                if (dsi.ContainsKey(xarr[1]))
                {
                    sum = dsi[xarr[1]];
                    int it = 2;
                    while (it < xarr.Length - 1 && !unknown_flag)
                    {
                        if (xarr[it].Equals("+"))
                        {
                            if (dsi.ContainsKey(xarr[it + 1]))
                            {
                                sum += dsi[xarr[it + 1]];
                            }
                            else
                            {
                                unknown_flag = true;
                            }
                        }
                        else
                        {
                            if (dsi.ContainsKey(xarr[it + 1]))
                            {
                                sum -= dsi[xarr[it + 1]];
                            }
                            else
                            {
                                unknown_flag = true;
                            }
                        }
                        it += 2;
                    }
                    if (!unknown_flag)
                    {
                        if (dis.ContainsKey(sum))
                        {
                            res = dis[sum];
                        }
                        else
                        {
                            unknown_flag = true;
                        }
                    }
                }
                else
                {
                    unknown_flag = true;
                }
                if (unknown_flag)
                {
                    res = "unknown";
                }
                x = x.Substring(5, x.Length - 5);
                Console.WriteLine("{0} {1}", x, res);
            }
            else if (xarr[0].Equals("clear"))
            {
                dsi = new Dictionary<string, int>();
                dis = new Dictionary<int, string>();
            }
            x = Console.ReadLine();
        }
    }
}
