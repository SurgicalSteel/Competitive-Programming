#include <bits/stdc++.h>
using namespace std;
typedef long long int lli;
typedef unsigned long long ull;
#define psb push_back
#define mkp make_pair
#define all(x) (x).begin(),(x).end()
#define PI acos(-1)
#define MOD 1000000007
struct point{
    int index;
    float x,y;
};
struct edge{
    int s,e;
    float w;
};
float dist(point a,point b){
    return sqrt(((a.x-b.x)*(a.x-b.x))+((a.y-b.y)*(a.y-b.y)));
}
bool checkNoCycle(vector<edge> v, edge c){
    bool checka = false, checkb=false;
    for(int i=0;i<v.size();i++){
        if((v[i].s==c.s || v[i].e==c.s)){checka=true;}
        if((v[i].s==c.e || v[i].e==c.e)){checkb=true;}
    }
    return ((checka&&!checkb)||(!checka&&checkb));
}
bool vicontains(vector<int> v, int x){
    vector<int>::iterator iter = find(all(v),x);
    return (iter!=v.end());
}
bool compare(edge const &a, edge const &b){
    return a.w<b.w;
}
int main() {
    // your code goes here
    int tc,n;
    vector<point> vp;
    vector<edge> ve,res;
    vector<int> visited,used;
    point tp;
    edge te;
    float tot=0;
    scanf("%d",&tc);
    bool sa,sb;
    for(int x=0;x<tc;x++){
        scanf("%d",&n);
        tot=0;
        vp.clear();
        ve.clear();
        res.clear();
        used.clear();
        visited.clear();
        for(int i=0;i<n;i++){
            cin>>tp.x>>tp.y;
            vp.psb(tp);
        }
        
        for(int j=0;j<n;j++){
            for(int i=0;i<n;i++){
                if (i>j){ // authentic, unique
                    te.s=i;
                    te.e=j;
                    te.w=dist(vp[i],vp[j]);
                    ve.psb(te);
                }
            }
        }
        sort(all(ve),compare);
//        for(int i=0;i<ve.size();i++){
//            cout<<ve[i].s<<"\t\t"<<ve[i].e<<"\t\t"<<ve[i].w<<"\n";
//        }
        res.psb(ve[0]);
        visited.psb(ve[0].s);
        visited.psb(ve[0].e);
        used.psb(0);
        tot+=ve[0].w;
        if (ve.size()>1){
            while(visited.size()<n){
                int j=0;
                bool breaker=false;
                while(j<ve.size()&&!breaker){
                    if (!vicontains(used,j)){
                        bool sts = (vicontains(visited,ve[j].s));
                        bool ste = (vicontains(visited,ve[j].e));
                        if ((sts||ste)&&!(sts&&ste)){
                            if(sts&&!ste){
                                visited.psb(ve[j].e);
                            }else{
                                visited.psb(ve[j].s);
                            }
                            tot+=ve[j].w;
                            used.psb(j);
                            breaker=true;
                        }
                    }
                    j++;
                }
            }
        }
        printf("%.9f\n",tot);
    }
    return 0;
}
