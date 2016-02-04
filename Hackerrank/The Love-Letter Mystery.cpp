#include <bits/stdc++.h>
using namespace std;
bool ispal(char c[],int len)
{
    bool valid=true;
    int i=0;
    while(i<len&&valid)
    {
        if(c[i]!=c[len-(i+1)]){valid=false;}
        else{i++;}
    }
    return valid;
}
int absolutey(int x)
{if(x<0){return x*-1;}else{return x;}}
int solve(string s)
{
    int counter=0,len=s.length();
    char cha[len];
    strncpy(cha, s.c_str(), sizeof(cha));
    //cha[sizeof(cha) - 1] = 0;
    int i=0,mini,abs;
    while(/*!ispal(cha,len)&&*/i<len)
    {
        mini=min(cha[i],cha[len-(i+1)]);
        abs=absolutey(cha[i]-cha[len-(i+1)]);
        if(cha[i]>cha[len-(i+1)])
        {
            cha[i]=mini;
            counter+=abs;
        }
        i++;
    }
    return counter;
}
int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */ 
    int tc;
    cin>>tc;
    int res[tc];
    string temp;
    for(int i=0;i<tc;i++)
    {
        cin>>temp;
        res[i]=solve(temp);
    }
    for(int i=0;i<tc;i++)
    {cout<<res[i]<<"\n";}
    return 0;
}
