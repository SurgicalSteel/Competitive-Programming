#include <bits/stdc++.h>
using namespace std;
string tostr(int x)
{
    ostringstream ss;
    ss<<x;
    return ss.str();
}
int main() {
    // your code goes here
    int iy,d,m,v,c=0,cm=0;
    string sd,sm;
    bool l=false;
    int lm []={31,28,31,30,31,30,31,31,30,31,30,31};
    for(int i=0;i<12;i++){cm+=lm[i];}
    cin>>iy;
    if (iy<1918){
        l=(iy%4==0);
    }else{
        l=((iy%400==0) || (iy%4==0 && iy%100!=0));
    }
    v=(256*12)/cm;
    for(int i=0;i<v;i++){
        c+=lm[i];
        m=i+1;
    }
    if (l){c++;}
    d=256-c;
    if (iy==1918){d+=13;}
    if (d>0){m++;}
    sd=tostr(d);
    sm=tostr(m);
    if (sd.length()==1){sd="0"+sd;}
    if (sm.length()==1){sm="0"+sm;}
    cout<<sd<<"."<<sm<<"."<<iy<<"\n";
    return 0;
}
