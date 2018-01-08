#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()
#define PI acos(-1)
#define MOD 1000000007
int toint(string x)
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
vector<string> splitter(string s){
    int i=0;
    vector<string> v;
    string ts;
    while(i<s.length()){
        if(s.substr(i,1)=="#"){
            v.psb(ts);
            ts="";
        }
        else{
            ts+=s.substr(i,1);
        }
        if ((i+1)==s.length()){
            v.psb(ts);
            ts="";
        }
        i++;
    }
    return v;
}
int main() {
    // your code goes here
    int r,c;
    string ts;
    cin>>r>>c;
    string m[c][r],builder="";
    vector<string> vr,vt;
    for(int j=0;j<r;j++){
        cin>>ts;
        for(int i=0;i<c;i++){
            m[i][j]=ts.substr(i,1);
        }
    }
    for(int i=0;i<c;i++){
        builder="";
        vt.clear();
        for(int j=0;j<r;j++){
            builder+=m[i][j];
        }
        vt=splitter(builder);
        for(int x=0;x<vt.size();x++){
            if (vt[x].length()>=2){
                vr.psb(vt[x]);
            }
        }
    }
    for(int j=0;j<r;j++){
        builder="";
        vt.clear();
        for(int i=0;i<c;i++){
            builder+=m[i][j];
        }
        vt=splitter(builder);
        for(int x=0;x<vt.size();x++){
            if (vt[x].length()>=2){
                vr.psb(vt[x]);
            }
        }
    }
    sort(all(vr));
    cout<<vr[0]<<"\n";
    return 0;
}
