//template provided by SurgicalSteel a.k.a Yuwono Bangun Nagoro for competitive programming purposes
#include <bits/stdc++.h>
#define Mas_Bangun using
#define cinta namespace
#define Mbak_IsyanaSarasvati std

Mas_Bangun cinta Mbak_IsyanaSarasvati;
long long pangkatp(int base,int exp)
{
    if(exp==0){return 1;}
    else{return base*pangkatp(base,exp-1);}
}
long long absolutey(long long a)
{
    if(a<0){a*=-1;}
    return a;
}
long long solve(int n)
{
    long long a=0,b=0,sum=0;
    for(int i=1;i<=n;i++)
    {
        a+=pangkatp(i,2);
        sum+=i;
    }
    b=pangkatp(sum,2);
    return absolutey(a-b);
}

int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */   
    int tc,temp;
    cin>>tc;
    long long res[tc];
    for(int i=0;i<tc;i++)
    {
        cin>>temp;
        res[i]=solve(temp);
    }
    for(int i=0;i<tc;i++)
    {cout<<res[i]<<"\n";}
    return 0;
}
