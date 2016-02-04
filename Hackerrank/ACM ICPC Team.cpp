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
int orcount(int a,int b)
{
    if(a==1||b==1){return 1;}
    else{return 0;}
}

int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */   
    int p,t;
    cin>>p>>t;
    int mskill[p][t];
    string arrstr[p];
    for(int i=0;i<p;i++)
    {cin>>arrstr[i];}    
    for(int i=0;i<p;i++)
    {
        for(int j=0;j<t;j++)
        {
            mskill[i][j]=toInt(arrstr[i].substr(j,1));
        }
    }
    int maxjo=0,jtim=0,temp=0;
    for(int i=0;i<p;i++)
    {
        for(int j=i;j<p;j++)
        {
            if(i!=j)
            {
                temp=0;
                for(int x=0;x<t;x++)
                {temp+=orcount(mskill[i][x],mskill[j][x]);}
                if(temp>maxjo){maxjo=temp;}
            }
        }
    }
    for(int i=0;i<p-1;i++)
    {
        for(int j=i+1;j<p;j++)
        {
            if(i!=j)
            {
                temp=0;
                for(int x=0;x<t;x++)
                {
                    temp+=(mskill[i][x]|mskill[j][x]);
                }
                if(temp==maxjo){jtim++;}
            }
        }
    }
    cout<<maxjo<<"\n"<<jtim<<"\n";
    return 0;
}
