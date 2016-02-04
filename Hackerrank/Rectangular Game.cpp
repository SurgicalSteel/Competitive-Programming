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
int main()
{
    //MAIN SECTION GOES HERE
    long long mina=100000000,minb=100000000;//a=baris,b=kolom
    int tc;
    cin>>tc;
    long long qa[tc],qb[tc];
    for(int i=0;i<tc;i++)
    {
        cin>>qa[i]>>qb[i];
        mina=min(qa[i],mina);
        minb=min(qb[i],minb);
    }
    long long num=mina*minb;
    cout<<num<<"\n";
    return 0;
}
