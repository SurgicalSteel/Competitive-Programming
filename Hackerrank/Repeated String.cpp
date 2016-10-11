#include <bits/stdc++.h>
using namespace std;
int main(){
    long long int x=0,n;
    string s;
    cin>>s;
    cin>>n;
    for(int it=0;it<s.length();it++)
    {
        if(s.substr(it,1)=="a")
        {x++;}
    }
    x*=((n-(n%s.length()))/s.length());
    for(int it=0;it<(n%s.length());it++)
    {
        if(s.substr(it,1)=="a")
        {x++;}
    }
    cout<<x<<"\n";
    return 0;
}
