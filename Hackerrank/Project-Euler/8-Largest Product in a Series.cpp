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
long long solve(string s,int n,int k)
{
    long long maxi=-12,temp;
    for(int i=0;i<n-k;i++)
    {
        temp=1;
        for(int j=i;j<i+k;j++)
        {
            temp*=toInt(s.substr(j,1));
        }
        if(temp>maxi){maxi=temp;}
    }
    return maxi;
}
int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */   
    int tc,n,k;
    cin>>tc;
    long long res[tc];
    string stemp;
    for(int i=0;i<tc;i++)
    {
        cin>>n>>k;
        cin>>stemp;
        res[i]=solve(stemp,n,k);
    }
    for(int i=0;i<tc;i++)
    {cout<<res[i]<<"\n";}
    return 0;
}
