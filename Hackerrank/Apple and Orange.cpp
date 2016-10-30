#include <bits/stdc++.h>
#define psb push_back
using namespace std;
int main() {
    int sa,se,pa,po,na,no,t,ca=0,co=0;
    cin>>sa>>se>>pa>>po>>na>>no;
    for(int i=0;i<na;i++)
    {
        cin>>t;
        if(((pa+t)>=sa)&&((pa+t)<=se)){ca++;}
    }
    for(int i=0;i<no;i++)
    {
        cin>>t;
        if(((po+t)>=sa)&&((po+t)<=se)){co++;}
    }
    cout<<ca<<"\n"<<co<<"\n";
    return 0;
}
