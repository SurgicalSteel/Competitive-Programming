#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()
#define PI acos(-1)
#define MOD 1000000007
bool isanagram(string sa,string sb){
    sort(all(sa));
    sort(all(sb));
    return sa==sb;
}
bool isallanagram(string s, int d){
    bool valid=true;
    int szseg = s.length()/d;
    string sta,stb;
    vector<string> vs;
    for(int i=0;i<s.length();i+=szseg){
        vs.psb(s.substr(i,szseg));
    }
    int i=0;
    while(valid&&i<vs.size()-1){
        valid = valid && isanagram(vs[i],vs[i+1]);
        i++;
    }
    return valid;
}
vector<int> getdivider(int x){
    vector<int> vd;
    for(int i=1;(i*i)<=x;i++){
        if(x%i==0){
            vd.psb(i);
            if(x/i!=i){
                vd.psb(x/i);
            }
        }
    }
    return vd;
}
int main() {
    // your code goes here
    string w,r="";
    cin>>w;
    int wl = w.length(),seg;
    vector<int> div = getdivider(wl);
    sort(all(div));
    for(int id=0;id<div.size();id++){
        if(div[id]>1){
            if(isallanagram(w,div[id])){
                seg = w.length()/div[id];
                r=w.substr(0,seg);
            }
        }    
    }
    if(r==""){
        cout<<"-1\n";
    }else{
        cout<<r<<"\n";
    }
    return 0;
}
