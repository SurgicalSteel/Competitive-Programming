#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()
#define PI acos(-1)
#define MOD 1000000007
struct point{int x,y;};
struct koef{int a,b,c;};
koef makekoef(point ps,point pd)
{
    koef k;
    k.b=pd.x-ps.x;
    k.a=ps.y-pd.y;
    k.c=(pd.x*ps.y)-(ps.x*pd.y);
    return k;
}
struct city{
    string name;
    int order;
    point pos;
    float dist;
};
float linedist(koef k, point p){
    k.c = k.c * (-1);
    float a,b;
    a=float((k.a*p.x) + (k.b*p.y) + k.c);
    if (a<0){a *= (-1);}
    b= float(sqrt(float(k.a*k.a) + float(k.b*k.b)));
    return a/b;
}
bool compare (city const &a, city const &b){
    return a.order<b.order;
}
int main() {
    // your code goes here
    int tc,nc;
    cin>>tc;
    point ha,hb;
    vector<city> v,vs;
    city tmpc;
    koef currkoef;
    float minidist;
    for(int i=0;i<tc;i++){
        cin>>ha.x>>ha.y>>hb.x>>hb.y;
        currkoef = makekoef(ha,hb);
        v.clear();
        vs.clear();
        cin>>nc;
        minidist=2000000000;
        for(int j=0;j<nc;j++){
            cin>>tmpc.name>>tmpc.pos.x>>tmpc.pos.y;
            tmpc.order = j;
            tmpc.dist = linedist(currkoef, tmpc.pos);
            v.psb(tmpc);
            minidist = min(minidist, tmpc.dist);
        }
        for(int k=0;k<v.size();k++){
            if (v[k].dist == minidist){
                vs.psb(v[k]);
            }
        }
        sort(all(vs),compare);
        for(int k=0;k<vs.size();k++){
            cout<<vs[k].name<<" ";
        }
        cout<<"\n";
        
    }
    return 0;
}
