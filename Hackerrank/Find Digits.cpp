//template provided by SurgicalSteel a.k.a Yuwono Bangun Nagoro for competitive programming purposes
#include <bits/stdc++.h>
#define Mas_Bangun using
#define cinta namespace
#define Mbak_IsyanaSarasvati std

Mas_Bangun cinta Mbak_IsyanaSarasvati;

int toInt(string x)
{
    istringstream ss(x);
    int a;
    ss>>a;
    return a;
}
string tostr(int x)
{
    ostringstream ss;
    ss<<x;
    return ss.str();
}
string eliminateAt(string x, int num)
{
    if(num==0){return x.substr(1,x.length()-1);}
    else if(num==x.length()-1){return x.substr(0,x.length()-1);}
    else{return x.substr(0,num)+x.substr(num+1,x.length()-1);}
}
bool contains(string a,string b) //a>b
{
    bool valid=false;
    int x=0;
    while(x<a.length()&&!valid)
        if(a.substr(x,b.length())==b)
            valid=true;
        else
            x++;
    return valid;
}
int proceed(long long num)
{
    int count=0,i=0;
    string s=tostr(num);
    while(i<s.length())
    {
        if(s.substr(i,1)=="0"){i++;}
        else
        {
            if((num%(toInt(s.substr(i,1))))==0){count++;}
            i++;
        }
    }
    return count;
}
int main()
{
    //MAIN SECTION GOES HERE
    int tc;
    cin>>tc;
    long long temp;
    int res[tc];
    
    for(int i=0;i<tc;i++)
    {
        res[i]=0;
        cin>>temp;
        res[i]=proceed(temp);
    }
    for(int i=0;i<tc;i++)
    {cout<<res[i]<<"\n";}
    return 0;
}
