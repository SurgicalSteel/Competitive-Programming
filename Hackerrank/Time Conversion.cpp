//template provided by SurgicalSteel a.k.a Yuwono Bangun Nagoro for competitive programming purposes
#include <bits/stdc++.h>
#define Mas_Bangun using
#define cinta namespace
#define Mbak_IsyanaSarasvati std

Mas_Bangun cinta Mbak_IsyanaSarasvati;

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
string conv(string hour)
{
    if(hour.substr(0,1)!="0"){return tostr(toInt(hour)+12);}
    else{return tostr(toInt(hour.substr(1,1))+12);}
}
int main() {
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */   
    string inp;
    getline(cin,inp);
    if(contains(inp,"AM"))
       {
           if(inp.substr(0,2)=="12"){cout<<"00"<<inp.substr(2,6)<<"\n";}
           else{cout<<inp.substr(0,8)<<"\n";}
       }
    if(contains(inp,"PM"))
       {
           if(inp.substr(0,2)=="12"){cout<<"12"<<inp.substr(2,6)<<"\n";}
           else{cout<<conv(inp.substr(0,2))<<inp.substr(2,6)<<"\n";}
       }
    return 0;
}
