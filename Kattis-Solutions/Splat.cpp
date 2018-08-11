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
    double x;
    double y;
};
struct circle{
    point center;
    double radius;
    string colour;
};
bool isinside(circle c, point p){
    double xcc = c.center.x;
    double ycc = c.center.y;
    return (((p.x - xcc)*(p.x - xcc)) + ((p.y- ycc)*(p.y- ycc)) <= (c.radius *c.radius));
}
double getradius(double v){
    return sqrt(v/PI);
}
int main() {
    // your code goes here
    int npd,ns,nq;
    double tcx,tcy,tv,tqx,tqy;
    string tco,tqco;
    circle tcr;
    point tqp;
    cin>>npd;
    for(int inpd = 0 ;inpd<npd;inpd++){
        cin>>ns;
        vector<circle> vsp;
        for(int ins=0;ins<ns;ins++){
            cin>>tcx>>tcy>>tv>>tco;
            tcr.center.x=tcx;
            tcr.center.y=tcy;
            tcr.colour=tco;
            tcr.radius=getradius(tv);
            vsp.psb(tcr);
        }
        cin>>nq;
        for(int inq=0;inq<nq;inq++){
            tqco="white";
            cin>>tqx>>tqy;
            tqp.x=tqx;
            tqp.y=tqy;
            for(int tsq=0;tsq<vsp.size();tsq++){
                if(isinside(vsp[tsq],tqp)){
                    tqco=vsp[tsq].colour;
                }
            }
            cout<<tqco<<"\n";
        }
    }
    return 0;
}
