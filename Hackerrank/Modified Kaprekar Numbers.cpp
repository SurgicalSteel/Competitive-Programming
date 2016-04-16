#include <bits/stdc++.h>
#define psb push_back
using namespace std;
int toInt(string x)
{
    istringstream ss(x);
    int a;
    ss>>a;
    return a;
}
long long int toll(string x)
{
    istringstream ss(x);
    long long int a;
    ss>>a;
    return a;
}
string lltostr(long long int x)
{
    ostringstream ss;
    ss<<x;
    return ss.str();
}
string tostr(int x)
{
    ostringstream ss;
    ss<<x;
    return ss.str();
}
long long power(int base,int exp)
{
    if(exp==0){return 1;}
    else {return base*power(base,exp-1);}
}
bool iskaprekar(long long int x, int sourcenum)
{
    if(sourcenum==1){return true;}
    vector<string> vs;
    string s=lltostr(x);
    for(int i=0;i<s.length();++i){vs.psb(s.substr(i,1));}
    string buildleft="",buildright="";
    if(s.length()%2==0)
    {
        for(int i=0;i<(s.length()/2);++i)
        {buildleft+=vs[i];}
        for(int i=(s.length()/2);i<s.length();++i)
        {buildright+=vs[i];}
    }
    else
    {
        for(int i=0;i<((s.length()-1)/2);++i)
        {buildleft+=vs[i];}
        for(int i=((s.length()-1)/2);i<s.length();++i)
        {buildright+=vs[i];}
    }
    return (toll(buildleft)+toll(buildright)==(long long int) sourcenum);
}

int main() {
    int p,q;
    vector<int> vk;
    scanf("%d %d",&p,&q);
    for(int i=p;i<=q;++i)
    {if(iskaprekar(power(i,2),i)){vk.psb(i);}}
    if(vk.size()>0)
    {
        for(int i=0;i<vk.size();++i)
        {
            if((i+1)<vk.size()){printf("%d ",vk[i]);}
            else{printf("%d\n",vk[i]);}
        }
    }
    else{printf("INVALID RANGE\n");}
    return 0;
}
