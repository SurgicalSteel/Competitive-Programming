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
int main()
{
    //MAIN SECTION GOES HERE
    double sump=0,sumn=0,sumz=0;
    int tc,temp;
    cin>>tc;
    for(int i=0;i<tc;i++)
    {
        cin>>temp;
        if(temp==0){sumz+=1;}
        else if(temp<0){sumn+=1;}
        else {sump+=1;}
    }
    cout<<setprecision(3)<<sump/tc<<"\n"<<sumn/tc<<"\n"<<sumz/tc<<"\n";
    return 0;
}
